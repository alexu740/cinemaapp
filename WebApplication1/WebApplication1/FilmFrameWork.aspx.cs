using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication1
{
    public partial class FilmFrameWork : System.Web.UI.Page
    {
        Button[] buttons;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            buttons = new Button[21]
            {
            Button1, Button2, Button3,
            Button4, Button5, Button6, Button7, Button8,
            Button9, Button10, Button11, Button12, Button13,
            Button14, Button15, Button16, Button17, Button18,
            Button19,Button20, Button21
            };
            retrieveFromDB(WebForm2.clickedFilm);
            
                Panel3.Visible = false;
            if (isLogged())
            {
                Panel3.Visible = false;
                Panel4.Visible = true;

            }
            else {
                Panel4.Visible = false;
                Panel3.Visible = true;
            }
            
           

        }
        // get the film from the DB by the film ID
        public void retrieveFromDB(int film_ID)
        {
            string query = "select * from seats WHERE Id_film = @film_ID";
            SqlParameter param = new SqlParameter("film_ID", film_ID);
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");


            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();


         
            int[] occupiedSeats = new int[22];
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int pos = ((int)dr.GetValue(1)-1)*7 + (int)dr.GetValue(2);
                    occupiedSeats[pos] = 1;
                }
                
            }
            showSeats(occupiedSeats);
        
        }
        // show the availble seats for the selected movie
        public void showSeats(int[] seats)
        {
            for(int i = 1; i<22; i++)
            {
                if (seats[i] == 1)
                {
                    buttons[i - 1].BackColor = System.Drawing.Color.Red;
                    buttons[i - 1].Enabled = false;
                }
                else
                    buttons[i - 1].BackColor = System.Drawing.Color.Green;
            }
        }
        // select a free seat
        public void saveSeat(Object sender, EventArgs e)
        {
            int row, col;
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "1":
                    Button1.BackColor = System.Drawing.Color.Yellow;
                    row = 1;
                    col = 1;
                    break;
                case "2":
                    row = 1;
                    col = 2;
                    Button2.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "3":
                    row = 1;
                    col = 3;
                    Button3.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "4":
                    row = 1;
                    col = 4;
                    Button4.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "5":
                    row = 1;
                    col = 5;
                    Button5.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "6":
                    row = 1;
                    col = 6;
                    Button6.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "7":
                    row = 1;
                    col = 7;
                    Button7.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "8":
                    Button8.BackColor = System.Drawing.Color.Yellow;
                    row = 2;
                    col = 1;
                    break;
                case "9":
                    Button9.BackColor = System.Drawing.Color.Yellow;
                    row = 2;
                    col = 2;
                    break;
                case "10":
                    Button10.BackColor = System.Drawing.Color.Yellow;
                    row = 2;
                    col = 3;
                    break;
                case "11":
                    row = 2;
                    col = 4;
                    Button11.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "12":
                    row = 2;
                    col = 5;
                    Button12.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "13":
                    row = 2;
                    col = 6;
                    Button13.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "14":
                    row = 2;
                    col = 7;
                    Button14.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "15":
                    row = 3;
                    col = 1;
                    Button15.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "16":
                    row = 3;
                    col = 2;
                    Button16.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "17":
                    row = 3;
                    col = 3;
                    Button17.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "18":
                    row = 3;
                    col = 4;
                    Button18.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "19":
                    row = 3;
                    col = 5;
                    Button19.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "20":
                    row = 3;
                    col = 6;
                    Button20.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "21":
                    row = 3;
                    col = 7;
                    Button21.BackColor = System.Drawing.Color.Yellow;
                    break;
                default:
                    row = 0;
                    col = 0;
                    break;
                

            }
            GlobalVar.row = row;
            GlobalVar.col = col;
           
        }
        // save the selected seat to DB
        public void seatToDB(int row, int col)
        {

            string query = "INSERT INTO seats VALUES(@Id, @row, @col)";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Assignment; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@Id", WebForm2.clickedFilm));
            cmd.Parameters.Add(new SqlParameter("@row", row));
            cmd.Parameters.Add(new SqlParameter("@col", col));
           

            con.Open();
            cmd.ExecuteNonQuery();
        
        }
        // check the validity of the credit card threw an existing web servi
        public void checkValidity(object sender, EventArgs e)
        {
            com.ftipgw.secure.CreditCardValidator validator = new com.ftipgw.secure.CreditCardValidator();
            int code = validator.ValidCard(TextBox2.Text, TextBox3.Text);

            if (GlobalVar.row != 0 && code == 0)
            {
                seatToDB(GlobalVar.row, GlobalVar.col);
                Response.Redirect("Receipt.aspx");
            }


        }

        public  Boolean isLogged()
        {
            using (StreamReader readtext = new StreamReader("user.txt"))

                return readtext.ReadLine() != "";

        }

        public  string getUser()
        {
            using (StreamReader readtext = new StreamReader("user.txt"))
                return readtext.ReadLine();
        }


        public void payLogged(object s, EventArgs e)
        {
            if (GlobalVar.row != 0)
            {
                seatToDB(GlobalVar.row, GlobalVar.col);
                Response.Redirect("Receipt.aspx");
            }
        }
    }
}