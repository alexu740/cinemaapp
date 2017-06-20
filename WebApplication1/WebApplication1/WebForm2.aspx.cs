using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private int Id = 3;
        public static int clickedFilm;
        protected void Page_Load(object sender, EventArgs e)
        {
            user.Text = getUser();
        }
        // redirect to the page with the selected movie's free seats
        public void buttonClick(object s, EventArgs e)
        {
            Button b = (Button)s;
            clickedFilm = Int32.Parse(b.CommandArgument);
            Response.Redirect("FilmFrameWork.aspx");
        }
        // add new movie to DB
        public void addToDatabase(string movie, string time, string desc)
        {
            
            string query = "INSERT INTO film(Id, movie, time, description) VALUES(@Id, @movie, @time, @desc)";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.Parameters.Add(new SqlParameter("@movie", movie));
            cmd.Parameters.Add(new SqlParameter("@time", time));
            cmd.Parameters.Add(new SqlParameter("@desc", desc));

            con.Open();
            cmd.ExecuteNonQuery();
            Id++;
        }
        // mark a seat as occupied in the DB
        public void addToDatabase2()
        {

            string query = "INSERT INTO seats VALUES(2, 1,2)";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            SqlCommand cmd = new SqlCommand(query, con);
            

            con.Open();
            cmd.ExecuteNonQuery();
        }
        //check if user is logged
        public Boolean isLogged()
        {
            using (StreamReader readtext = new StreamReader("user.txt"))

                return readtext.ReadLine() != "";

        }
        //get the email of the user that is logged
        public string getUser()
        {
            using (StreamReader readtext = new StreamReader("user.txt"))
            {
               
                return readtext.ReadLine();
            }
        }

    }
}