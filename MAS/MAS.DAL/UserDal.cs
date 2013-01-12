﻿using System;
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
            const string query = @"select * from SystemUser where UserName='@username' and UserPassword='@password'";
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
    }
}