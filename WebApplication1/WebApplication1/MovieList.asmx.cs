using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for MovieList
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MovieList : System.Web.Services.WebService
    {

        [WebMethod]
        public string[][] getAllMovies()
        {
         
            string query = "select * from seats";

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");


            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    i++;
                }
            }
            string[][] films = new string[i][];
            i = 0;
            {
                while (dr.Read())
                {

                    films[i++][0] = (String)dr.GetValue(0);
                    films[i][1] = (String)dr.GetValue(1);
                }
            }
            return films;
        }
    }
    
}
