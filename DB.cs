﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public class DB
    {
        public SqlConnection baglanti()
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\ucrmh\OneDrive\Masaüstü\Proje\PROJECT\Database1.mdf;
            Integrated Security=True;";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }
          
         


        

    }
}
