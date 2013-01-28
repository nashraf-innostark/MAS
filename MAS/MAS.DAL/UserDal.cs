using System;
using System.Data;
using System.Data.SqlClient;

namespace MAS.DAL
{
    using BusinessObject;
    /// <summary>
    /// DAL For User Entity
    /// CB:NA
    /// CD:12-January-2013
    /// </summary>
    public class UserDal
    {
        public UserDal()
        {
            
        }

        public User VerifyCredentials(string userName, string password)
        {
            const string query = @"select * from SystemUser SU inner join Role R on R.RoleId= SU.RoleId where SU.SocialSecurityNo like @username and SU.UserPassword=@password and SU.IsLocked=0";
            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmdVerfiyCredentials = new SqlCommand(query, con);
            cmdVerfiyCredentials.Parameters.AddWithValue("@username", userName);
            cmdVerfiyCredentials.Parameters.AddWithValue("@password", password);
            User result=new User();
            try
            {


                con.Open();
                using (con)
                {
                    SqlDataReader drUser = cmdVerfiyCredentials.ExecuteReader();

                    if (drUser.HasRows == true)
                    {
                        while (drUser.Read())
                        {
                            result.UserId = Convert.ToInt32(drUser["UserId"]);
                            result.UserName = Convert.ToString(drUser["UserName"]);
                            result.UserPassword = Convert.ToString(drUser["UserPassword"]);
                            result.RoleId = Convert.ToInt32(drUser["RoleId"]);
                            result.FirstName = Convert.ToString(drUser["FirstName"]);
                            result.LastName = Convert.ToString(drUser["LastName"]);
                            result.SocialSecurityNo = Convert.ToString(drUser["SocialSecurityNo"]);
                            result.RoleKey = Convert.ToInt16(drUser["RoleKey"]);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("User not Found!"+ ex.Message,ex);
            }
            
            
        }


        public User GetUserById(int id)
        {
            const string query = @"select * from SystemUser SU Where SU.UserId=@Id";
            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmdVerfiyCredentials = new SqlCommand(query, con);
            cmdVerfiyCredentials.Parameters.AddWithValue("@Id", id);
            User result = new User();
            try
            {


                con.Open();
                using (con)
                {
                    SqlDataReader drUser = cmdVerfiyCredentials.ExecuteReader();

                    if (drUser.HasRows == true)
                    {
                        while (drUser.Read())
                        {
                            result.UserId = Convert.ToInt32(drUser["UserId"]);
                            result.UserName = Convert.ToString(drUser["UserName"]);
                            result.UserPassword = Convert.ToString(drUser["UserPassword"]);
                            result.RoleId = Convert.ToInt32(drUser["RoleId"]);
                            result.FirstName = Convert.ToString(drUser["FirstName"]);
                            result.LastName = Convert.ToString(drUser["LastName"]);
                            result.SocialSecurityNo = Convert.ToString(drUser["SocialSecurityNo"]);
                            result.RoleKey = Convert.ToInt16(drUser["RoleKey"]);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("User not Found!" + ex.Message, ex);
            }


        }

        public User ValidateSsn(string ssn)
        {
            const string query = @"select * from SystemUser SU  where SU.SocialSecurityNo like @username";
            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmdVerfiyCredentials = new SqlCommand(query, con);
            cmdVerfiyCredentials.Parameters.AddWithValue("@username", ssn);
            User result = new User();
            try
            {
                con.Open();
                using (con)
                {
                    SqlDataReader drUser = cmdVerfiyCredentials.ExecuteReader();

                    if (drUser.HasRows == true)
                    {
                        while (drUser.Read())
                        {
                            result.UserId = Convert.ToInt32(drUser["UserId"]);
                            result.SocialSecurityNo = Convert.ToString(drUser["SocialSecurityNo"]);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("User not Found!" + ex.Message, ex);
            }
        }

        public User InsertOrUpdateUser(User user)
        {
            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmdInitiative = new SqlCommand("InsertOrUpdateInitiative  ");
            cmdInitiative.CommandType = CommandType.StoredProcedure;
            cmdInitiative.Parameters.AddWithValue("@Id",  user.UserId );
            //output.Direction = ParameterDirection.Output;
            cmdInitiative.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmdInitiative.Parameters.AddWithValue("@LastName", user.LastName);
            cmdInitiative.Parameters.AddWithValue("@Address", user.Address);
            cmdInitiative.Parameters.AddWithValue("@ZipCode", user.ZipCode);
            cmdInitiative.Parameters.AddWithValue("@City", user.City);
            cmdInitiative.Parameters.AddWithValue("@Country", user.Country);
            cmdInitiative.Parameters.AddWithValue("@PhoneHome", user.PhoneHome);
            cmdInitiative.Parameters.AddWithValue("@Gender", user.Gender);
            cmdInitiative.Parameters.AddWithValue("@PhoneWork", user.PhoneOffice);
            cmdInitiative.Parameters.AddWithValue("@SSN", user.SocialSecurityNo);
            cmdInitiative.Parameters.AddWithValue("@MaritalStatus", user.MaritalStatus);
            cmdInitiative.Parameters.AddWithValue("@Password", user.UserPassword);
            cmdInitiative.Parameters.AddWithValue("@Email", user.Email);
            cmdInitiative.Parameters.AddWithValue("@RecCreatedBy", user.RecCreatedBy);
            cmdInitiative.Parameters.AddWithValue("@RecUpdatedBy", user.RecLastUpdatedBy);
            cmdInitiative.Parameters.AddWithValue("@Other", user.Other);
            if (user.DOB.Equals(DateTime.MinValue))
                cmdInitiative.Parameters.AddWithValue("@DOB", DBNull.Value);
            else
                cmdInitiative.Parameters.AddWithValue("@DOB", user.DOB);
            con.Open();
            cmdInitiative.Connection = con;
            using (con)
            {
                int gottedId = Convert.ToInt32(cmdInitiative.ExecuteScalar());
                if (user.UserId == 0)
                    user.UserId = gottedId;
            }
            return user;
        }

    }
}
