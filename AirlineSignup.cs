using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlineapp
{
    public partial class AirlineSignup : Form
    {
        public AirlineSignup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mario\\Desktop\\airlineapp\\airlineapp\\DatabaseTest.mdf;Integrated Security=True");
        int val = 0;

        private void buttonSUbmit_Click(object sender, EventArgs e)
        {
            //this is to check and ensure all textboxes have data entered
            if (textBoxFName.Text == "" || textBoxEmail.Text == "" || textBoxPW1.Text == "" || textBoxPW2.Text == "") {

                MessageBox.Show("Error: No field should be left empty");
            }
             else
            {
               

                    if (textBoxPW1.Text == textBoxPW2.Text) //this is to ensure both passwords match
                    {
                        //establinshing a connection then sending data to a local database
                        SqlCommand cmd = new SqlCommand("insert into SignUpInfo values(@FullName,@Username,@Password)", con);
                        AutoIncrimentID();
                        cmd.Parameters.AddWithValue("@FullName", textBoxFName.Text);
                        cmd.Parameters.AddWithValue("@Username", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPW1.Text);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Saved Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Passwords do no match");
                    }
                }
            }

        private void AutoIncrimentID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(LoginId)from[LoginInfo]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            LabelID.Text = val + i.ToString();
            LabelID.Text = "";

        }

        private void buttonBacktomain_Click(object sender, EventArgs e)
        {
            AirlineHome f2 = new AirlineHome();

            // hide the current form
            this.Hide();

            // use the `Show()` method to access the new non-modal form
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AirlineSignup_Load(object sender, EventArgs e)
        {

        }
    }
}
