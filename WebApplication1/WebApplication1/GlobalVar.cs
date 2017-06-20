using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace WebApplication1
{
   // some global variables that are used.
        public class GlobalVar
        {
            public static string user;
            public static int row, col;
            
        public static Boolean isLogged()
        {
            using (StreamReader readtext = new StreamReader("user.txt"))
            
               return  readtext.ReadLine() != "";
            
        }

        public static string getUser()
        {
            using (StreamReader readtext = new StreamReader("user.txt"))
                return readtext.ReadLine();
        }
    }
    
}