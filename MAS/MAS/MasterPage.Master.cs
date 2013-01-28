using System;
using System.IO;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using MAS.Services;

namespace MAS
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        #region Public
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public String UserName { get; set; }
        public String UserFullName { get; set; }
        public String SocialSecurityNo { get; set; }
        public short RoleKey { get; set; }
        #endregion

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {

                var identity = ((FormsIdentity)HttpContext.Current.User.Identity);
                var str = identity.Ticket.UserData;
                var result = str.Split('|');
                int uId, rId;
                int.TryParse(result[0], out uId);
                int.TryParse(result[3], out rId);
                UserId = uId;
                RoleId = rId;
                UserName = result[1];
                UserFullName = result[2];
                SocialSecurityNo = result[4];
                RoleKey = Convert.ToInt16(result[5]);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
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
            else
            {
                lblusername.Text += " " + UserName;
            }
        }

        protected void LbLogoutClick(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Session.Abandon();
                FormsAuthentication.SignOut();
                Response.Redirect("Default.aspx");
            }
        }
    }
}