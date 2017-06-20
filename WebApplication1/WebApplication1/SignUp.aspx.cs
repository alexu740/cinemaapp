using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // create new user, add it to the DB
        public void signUp(object sender, EventArgs e)
        {
            if(!checkCredentials(TextBox4.Text, TextBox5.Text)) return;
            string user = TextBox1.Text;
            string password = TextBox2.Text;
            string email = TextBox3.Text;
            string ccnumber = TextBox4.Text;
            string expDate = TextBox5.Text;


            string query = "INSERT INTO customer VALUES(@user, @pass, @email, @ccnumber, @expDate)";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@user", user));
            cmd.Parameters.Add(new SqlParameter("@pass", password));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@ccnumber", ccnumber));
            cmd.Parameters.Add(new SqlParameter("@expDate", expDate));


            con.Open(); 
            cmd.ExecuteNonQuery();

           
        }
        // check trew the web service if the credit card is valid
        public Boolean checkCredentials(string cc, string exDate)
        {
            com.ftipgw.secure.CreditCardValidator validator = new com.ftipgw.secure.CreditCardValidator();
            return validator.ValidCard(cc, exDate) == 0;
        }
    }
   
}