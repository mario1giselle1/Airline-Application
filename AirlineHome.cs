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
using System.Reflection.Emit;


namespace airlineapp
{
    public partial class AirlineHome : Form
    {
        public AirlineHome()
        {
            InitializeComponent();


        }

        float Return1 = 100000, oneWay = 70000, Multentry = 120000;
        double childDiscount = 0.5;
        int childP, AdultP;
        double Totalprice, Addprice;

        private void AirlineHome_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //num1 = int.Parse(txtTotal.Text);
            AdultP = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            childP = int.Parse(textBox2.Text);

        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mario\\Desktop\\airlineapp\\airlineapp\\DatabaseTest.mdf;Integrated Security=True");
        int val = 0;
        private void AutoIncrimentID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(FlightID)from[FLightData]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            LabelID.Text = val + i.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckButtons();
            //database section this will connect the windows for to the database then send things to the table
            ////////string ConnectionString = "Data Source=LAPTOP-ADCE03PD;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into FLightData values(@Typeofflight,@DepartureD,@ReturnD,@NumberOfAdults,@NumberOfChildren,@TotalCost)", con);
            if (radioButton1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Typeofflight", radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Typeofflight", radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Typeofflight", radioButton3.Text);
            }
            cmd.Parameters.AddWithValue("@DepartureD", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@ReturnD", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@NumberOfAdults", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NumberOfChildren", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@TotalCost", Totalprice);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully \n Number of Adult:" + AdultP + " Number of Children:" + childP + " " + " \n Travel date:" + this.dateTimePicker1.Text + "\n Return Date:" + this.dateTimePicker2.Text + "\nBalance$" + Totalprice);
        }
        //this is to check wich radio button was clicked :)
        public void CheckButtons()
        {
            if (radioButton1.Checked)
            {

                Totalprice = (Return1 * ((childP * childDiscount) + AdultP));
            }
            else if (radioButton2.Checked)
            {
                Totalprice = (oneWay * ((childP * childDiscount) + AdultP));

            }
            else if (radioButton3.Checked)
            {
                Totalprice = (Multentry * ((childP * childDiscount) + AdultP));

            }
            else
            {
                MessageBox.Show("Please select the type of flight you would like");
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            //return checkbox

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //oneway checkbox
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //multicity checkbox
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this code will only allow numbers to be entered in both text boxes
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("only numbers can be entered!");
            }
            else
            {

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("only numbers can be entered!");
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //this is to enable a return flight
            dateTimePicker2.Enabled = true;

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {


            if (radioButton3.Checked)
            {
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker2.Enabled = true;
            }

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

            dateTimePicker2.Enabled = true;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //this is to change the date time value
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //i need to keep my hand on the key board
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }
        //irrelivant
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AirlineLogin f2 = new AirlineLogin();

            // hide the current form
            this.Hide();

            // use the `Show()` method to access the new non-modal form
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirlineSignup f2 = new AirlineSignup();

            // hide the current form
            this.Hide();

            // use the `Show()` method to access the new non-modal form
            f2.Show();
        }
    }
}
