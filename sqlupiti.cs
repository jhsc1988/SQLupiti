using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SQLupiti
{

    public partial class sqlupiti : Form
    {
        static String connetionString = @"Server=F00BAR\SQLEXPRESS;Database=java_lab;Trusted_Connection=True;";
        public sqlupiti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand(tbQuery.Text, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                int fieldCount = reader.FieldCount;

                while (reader.Read())
                {
                    for (int i = 0; i < fieldCount; ++i)
                    {
                        sb.Append(reader.GetValue(i).ToString() + " ");
                    }
                    sb.Append("\r\n");
                }

                queryResult.Text += sb.ToString();

                connection.Close();
                reader.Close();
            }
            catch (InvalidOperationException ioeEx)
            {
                MessageBox.Show(ioeEx.Message);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }
    }
}
