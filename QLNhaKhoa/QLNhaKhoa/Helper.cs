﻿using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    internal class Helper
    {
        public static string strCon = "Data Source=HUY;Initial Catalog=Nhom3_QLNhaKhoa;Integrated Security=True;TrustServerCertificate=True";
        public static DataSet getData(string query)
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter ap = new SqlDataAdapter(query, sqlCon);
            ap.Fill(dt);
            sqlCon.Close();
            return dt;
        }
        public static void loadform(object Form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }
    }
}
