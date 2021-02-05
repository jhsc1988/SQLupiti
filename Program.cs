using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace SQLupiti
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                String connetionString = @"Servr=F00BAR\SQLEXPRESS;Database=java_lab;Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connetionString);

                connection.Open();
                MessageBox.Show("Connection Open  !");
                connection.Close();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sqlupiti());



        }
    }
}
