using System.Data.SqlClient;
namespace sqlconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {


        }

        private void lblbtn_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void signup_txt_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string password = password1.Text;
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sedatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {

                string query = "INSERT INTO loginTable (Name,password) VALUES (@name,@password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
                MessageBox.Show("User sign successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string newPassword = password1.Text;
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sedatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {
                string query = "UPDATE loginTable SET password = @newPassword WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@name", name);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully");
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sedatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {
                string query = "DELETE FROM loginTable WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully");
                    username.Text = ""; 
                    password1.Text = ""; 
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
