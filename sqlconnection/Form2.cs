using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sqlconnection
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = username_text.Text;
            string password = password_txt.Text;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sedatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                

                string query = "SELECT COUNT(*) FROM loginTable WHERE password = @password AND name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", name);
                
                cmd.Parameters.AddWithValue("@password", password);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("User logged in successfully");
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password "+name+password);
                }

                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
