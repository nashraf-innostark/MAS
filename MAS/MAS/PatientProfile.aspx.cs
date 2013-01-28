using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MAS.BusinessObject;
using MAS.Controller;

namespace MAS
{
    public partial class PatientProfile : System.Web.UI.Page
    {

        #region Private
        IFormatProvider frmt = new System.Globalization.CultureInfo("en-us", true);
        private bool ValidateValues()
        {
            int id = 0;
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                id = Convert.ToInt32(Request.QueryString["Id"]);
            }
            User ini = new UserController().ValidateSsn(txtSSN.Text,id);
            return ini == null;
        }

        private void InsertOrUpdateUser()
        {
            if (ValidateValues())
            {

                User patient = new User();
                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    patient.UserId = Convert.ToInt32(Request.QueryString["Id"]);
                }
                patient.FirstName = txtFirstName.Text;
                patient.LastName = txtLastName.Text;
                patient.Address = txtAddress.Text;
                patient.ZipCode = txtZipCode.Text;
                patient.City = txtCity.Text;
                patient.Country = txtCountry.Text;
                patient.PhoneHome = txtHomePhone.Text;
                patient.Gender = Convert.ToInt16(ddlGender.SelectedValue);
                patient.MaritalStatus = Convert.ToInt16(ddlMaritalStatus.SelectedValue);

                patient.PhoneOffice = txtWorkPhone.Text;
                patient.SocialSecurityNo = txtSSN.Text;
                patient.Other = txtOther.Text;
                patient.UserPassword = txtPassword.Text;
                patient.DOB = Convert.ToDateTime(txtDOB.Text, frmt);
                patient.Email = txtEmail.Text;

                UserController inicontroller = new UserController();
                inicontroller.InsertOrUpdateUser(patient);
               
            }
        }

        private void LoadUser(User patient)
        {

            txtFirstName.Text = patient.FirstName ;
            txtLastName.Text = patient.LastName;
            txtAddress.Text= patient.Address ;
            txtZipCode.Text= patient.ZipCode ;
            txtCity.Text = patient.City ;
            txtCountry.Text = patient.Country;
            txtHomePhone.Text = patient.PhoneHome ;
            ddlGender.SelectedValue = patient.Gender.ToString(CultureInfo.InvariantCulture) ;
            ddlMaritalStatus.SelectedValue = patient.MaritalStatus.ToString(CultureInfo.InvariantCulture);
            txtWorkPhone.Text = patient.PhoneOffice;
            txtSSN.Text = patient.SocialSecurityNo;
            txtOther.Text = patient.Other;
            txtPassword.Text = patient.UserPassword;
            txtPasswordConfirm.Text = patient.UserPassword;
            txtDOB.Text= patient.DOB.ToString("dd/MM/yyyy");
            txtEmail.Text = patient.Email;
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Master != null)
                {
                    Label pageTitle = Master.FindControl("lblpageheader") as Label;
                    if (pageTitle != null) pageTitle.Text = "Patient Profile";
                }
                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    User init = new UserController().GetUserById(id);
                    LoadUser(init);
                }
            }

        }

        protected  void BtnSaveClick(object sender, EventArgs e)
        {
             InsertOrUpdateUser();
            //if (getUser != null)
            //    if (getUser.UserId > 0)
            //        Helper.UIUtility.showMessage("Project has been saved", false, this);
        }


    }
}