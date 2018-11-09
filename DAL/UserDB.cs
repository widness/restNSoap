using DTO;
using System.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDB
    {
        public static int GetUID(string username)
        {
            int uId = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseDataAccess"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    string query = "Select * from UserSAP where UserName = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            uId = (int)dr["UserID"];

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return uId;
        }
        public static int GetUID(int carteID)
        {
            int uid = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseDataAccess"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    string query = "Select * from UserSAP where CarteID = @carteID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@carteID", carteID);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            uid = (int)dr["UserID"];

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return uid;
        }
        public static string GetUsername(int uid)
        {
            string username = null;

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseDataAccess"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    string query = "Select * from UserSAP where UserID = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            username = (string)dr["UserName"];

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return username;
        }
        public static double GetAmount(int uid)
        {
            double amount = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseDataAccess"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    string query = "Select Quotas from UserPrintSystem where UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UserID", uid);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr["Quotas"] != null)
                                amount = (double)dr["Quotas"];

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return amount;
        }

        public static double AddAmount(double amount, int uid)
        {
            int result = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseDataAccess"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
        
                    string query = "UPDATE UserPrintSystem SET quotas = @amount WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UserID", uid);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return UserDB.GetAmount(uid);
        }
    }
}
