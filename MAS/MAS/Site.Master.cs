using System;
using System.IO;
using System.Security.Cryptography;
using System.Web;
using MAS.Services;

namespace MAS
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginService service = new LoginService();
            byte[] data = service.GetPublicKey();
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                string[] key = File.ReadAllLines(Server.MapPath("~/App_Data/AESKey.txt"));
                rijAlg.Key = Convert.FromBase64String(key[0]);
                rijAlg.IV = Convert.FromBase64String(key[1]);

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(data))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            txtKey.Text = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            HttpCookie cookieUserName = Request.Cookies["UserName"];
            HttpCookie cookiePassword = Request.Cookies["Password"];
            if (cookieUserName != null)
            {
               // UserName.Attributes.Add("value", cookieUserName.Value);
            }

            if (cookiePassword != null)
            {
               // Password.Attributes.Add("value", cookiePassword.Value);
            }

        }
    }
}
