namespace airlineapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AirlineHome f2 = new AirlineHome();

            // hide the current form
            this.Hide();

            // use the `Show()` method to access the new non-modal form
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //i changed the vairble name but this is no different from above
            AirlineSignup Link = new AirlineSignup();
            this.Hide();
            Link.Show();
        }
    }
}