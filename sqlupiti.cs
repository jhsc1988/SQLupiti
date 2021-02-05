using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLupiti
{

    public partial class sqlupiti : Form
    {
        static String connetionString = @"Server=F00BAR\SQLEXPRESS;Database=java_lab;Trusted_Connection=True;";
        public sqlupiti()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand(tbQuery.Text,connection);

                connection.Open();
                MessageBox.Show("Connection Open!");


                SqlDataReader reader = cmd.ExecuteReader();
                List<string> str = new List<string>();

                int fieldCount = reader.FieldCount;
                while (reader.Read())
                {
                    int i = 0;
                    while (i < fieldCount)
                    {
                        str.Add(reader.GetValue(i).ToString() + " ");
                        i++;
                    }
                    str.Add("\r\n");
                    
                }
                foreach (string qR in str)
                {
                    queryResult.Text += qR;
                }
                connection.Close();
                reader.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
