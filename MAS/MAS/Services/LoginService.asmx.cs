using System;
using System.IO;
using System.Web;
using System.Web.Services;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;
using MAS.BusinessObject;
using MAS.Controller;

namespace MAS.Services
{

    /// <summary>
    /// Summary description for LoginService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.Web.Script.Services.ScriptService]
    public class LoginService : WebService
    {

        /// <summary>
        /// Gets the public key and add it to cache for 1 day
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        [WebMethod(CacheDuration = 24 * 60 * 60)]
        public byte[] GetPublicKey()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //Add Key Pair (Public + Private Key) to Cache to be used by ValidateUser
            HttpRuntime.Cache["KeyPair"] = rsa.ToXmlString(true);
            RSAParameters param = rsa.ExportParameters(false);

            string keyToSend = ToHexString(param.Exponent) + "," +
                 ToHexString(param.Modulus);

            // Encrypting public key to block Man-in-the-Middle attack
            byte[] encrypted;
            using (RijndaelManaged myRijndael = new RijndaelManaged())
            {
                string[] key = File.ReadAllLines(Server.MapPath("~/App_Data/AESKey.txt"));
                myRijndael.Key = Convert.FromBase64String(key[0]);
                myRijndael.IV = Convert.FromBase64String(key[1]);
                ICryptoTransform encryptor = myRijndael.CreateEncryptor();
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            swEncrypt.Write(keyToSend);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        /// <summary>
        /// Validates the user
        /// </summary>
        /// <param name="encUsername">The encrypted username</param>
        /// <param name="encPassword">The encrypted password</param>
        /// <param name="rememberMe">Wheather Remember Me selected by user</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [WebMethod(EnableSession = true)]
        public bool ValidateUser(string encUsername, string encPassword, bool rememberMe)
        {
            // Check request number from this ip is in allowed range
            if (!ActionValidator.IsValid(ActionValidator.ActionTypeEnum.FirstVisit))
                return false;

            //read Key Pair (Public + Private Key) from Cache
            string domainKey = (string)HttpRuntime.Cache["KeyPair"];

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(domainKey);
            string username = Encoding.UTF8.GetString(rsa.Decrypt(ToHexByte(encUsername), false));
            string password = Encoding.UTF8.GetString(rsa.Decrypt(ToHexByte(encPassword), false));
             User  user = new UserController().VerifyUser(username, password);
            if (user.UserId > 0)
            {

                // Query the user store to get this user's User Data

                string userDataString = user.UserId + "|" + user.UserName + "|" + user.FirstName + " " + user.LastName +
                                        "|" + user.RoleId;

                // Create the cookie that contains the forms authentication ticket

                HttpCookie authCookie = FormsAuthentication.GetAuthCookie(username, false);

                // Get the FormsAuthenticationTicket out of the encrypted cookie

                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);

                // Create a new FormsAuthenticationTicket that includes our custom User Data

                FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name,
                                                                                    ticket.IssueDate, ticket.Expiration,
                                                                                    ticket.IsPersistent, userDataString);

                // Update the authCookie's Value to use the encrypted version of newTicket

                authCookie.Value = FormsAuthentication.Encrypt(newTicket);

                // Manually add the authCookie to the Cookies collection
                HttpContext.Current.Response.Cookies.Add(authCookie);
                return true;
            }
            return false;
        }

        public static string ToHexString(byte[] byteValue)
        {
            char[] lookup = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int i = 0, p = 0, l = byteValue.Length;
            char[] c = new char[l * 2];
            while (i < l)
            {
                byte d = byteValue[i++];
                c[p++] = lookup[d / 0x10];
                c[p++] = lookup[d % 0x10];
            }
            return new string(c, 0, c.Length);
        }
        public static byte[] ToHexByte(string str)
        {
            byte[] b = new byte[str.Length / 2];
            for (int y = 0, x = 0; x < str.Length; ++y, x++)
            {
                byte c1 = (byte)str[x];
                if (c1 > 0x60) c1 -= 0x57;
                else if (c1 > 0x40) c1 -= 0x37;
                else c1 -= 0x30;
                byte c2 = (byte)str[++x];
                if (c2 > 0x60) c2 -= 0x57;
                else if (c2 > 0x40) c2 -= 0x37;
                else c2 -= 0x30;
                b[y] = (byte)((c1 << 4) + c2);
            }
            return b;
        }
    }

}


