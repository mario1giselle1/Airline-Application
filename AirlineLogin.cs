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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace airlineapp
{
    public partial class AirlineLogin : Form
    {
        public AirlineLogin()
        {
            InitializeComponent();
        }
        //Sql data connection
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mario\\Desktop\\airlineapp\\airlineapp\\DatabaseTest.mdf;Integrated Security=True");
        int val = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "MarioMatt" && textBox2.Text == "ForData")
            {
                //this is to send you to the employee side of the project
                AirlineEmployer NewForm = new AirlineEmployer();
                this.Hide();
                NewForm.Show();
            }
            else
            {

                string username, Password;
                username = textBox1.Text; Password = textBox2.Text;

                try
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("One or more fields are empty");
                    }
                    else
                    {

                        string Query1z = "Select * From SignUpInfo Where Email ='" + textBox1.Text + "'ANd Passwords ='" + textBox2.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(Query1z, con);
                        DataTable Dtable = new DataTable();
                        sda.Fill(Dtable);
                        if (Dtable.Rows.Count > 0)
                        {
                            username = textBox1.Text;
                            Password = textBox2.Text;
                            MessageBox.Show("Welcome" + textBox1.Text);
                            AirlineHome NewForm = new AirlineHome();
                            this.Close();
                            NewForm.Show();
                        }
                        else
                        {

                            MessageBox.Show("Username and password do not match \n Please try again.");
                            textBox1.Clear();
                            textBox2.Clear();

                            //to focus username
                            textBox1.Focus();
                        }


                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

        }
    }
}
