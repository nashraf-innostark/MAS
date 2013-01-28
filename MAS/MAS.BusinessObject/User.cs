using System;
namespace MAS.BusinessObject
{
    /// <summary>
    /// System User Entity
    /// CB:NA
    /// CD:12-January-2013
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int ClinicId { get; set; }
        public String UserName { get; set; }
        public String Address { get; set; }
        public String UserPassword { get; set; }
        public String ZipCode { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public short Gender { get; set; }
        public short MaritalStatus { get; set; }
        public String FirstName { get; set; }
        public String Other { get; set; }
        public String LastName { get; set; }
        public String SocialSecurityNo { get; set; }
        public String Mobile { get; set; }
        public String PhoneHome { get; set; }
        public String PhoneOffice { get; set; }
        public String Email { get; set; }
        public String Speciality { get; set; }
        public bool IsLocked { get; set; }
        public short RoleKey { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime DOB { get; set; }
        public DateTime RecCreatedDate { get; set; }
        public DateTime RecLastUpdatedDate { get; set; }
        public int RecLastUpdatedBy { get; set; }
        public int RecCreatedBy { get; set; }
    }
}
