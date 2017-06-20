using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1
{
    public partial class Login1 : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //check if user exists in the DB, if yes, save to file the email of the user that is logged
        public void login(object sender, EventArgs e)
        {

            string query = "select * from customer WHERE email = @email and password = @pass";
            SqlParameter param = new SqlParameter("email", TextBox1.Text);
            SqlParameter param2 = new SqlParameter("pass", TextBox2.Text);
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");


            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) {


                using (StreamWriter writetext = new StreamWriter("user.txt"))
                {
                    writetext.WriteLine(TextBox1.Text);
                }
                Response.Redirect("WebForm2.aspx");

            }
           
        }
        
        public static string getUser()
        {
            return GlobalVar.getUser();
            
        }
        public Boolean  isLogged()
        {
            return GlobalVar.isLogged();
        }
    }
}