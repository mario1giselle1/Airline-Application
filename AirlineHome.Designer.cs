namespace airlineapp
{
    partial class AirlineHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirlineHome));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            LabelID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 120);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 45);
            label1.Name = "label1";
            label1.Size = new Size(291, 43);
            label1.TabIndex = 1;
            label1.Text = "Mario's Airline";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 164);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 1;
            label2.Text = "Book Flight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 295);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 2;
            label3.Text = "Departure Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 386);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 3;
            label4.Text = "Return Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 504);
            label5.Name = "label5";
            label5.Size = new Size(158, 29);
            label5.TabIndex = 4;
            label5.Text = "Number of Adults";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(20, 235);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 30);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Return\r\n";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(260, 235);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(109, 30);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Multi-city\r\n";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(131, 235);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(99, 30);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "One way\r\n";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            radioButton3.Click += radioButton3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(9, 330);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(11, 446);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            dateTimePicker2.KeyDown += dateTimePicker2_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 558);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 558);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 31);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(211, 504);
            label6.Name = "label6";
            label6.Size = new Size(176, 29);
            label6.TabIndex = 11;
            label6.Text = "Number of Children";
            // 
            // button1
            // 
            button1.Location = new Point(10, 616);
            button1.Name = "button1";
            button1.Size = new Size(392, 34);
            button1.TabIndex = 13;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 707);
            button2.Name = "button2";
            button2.Size = new Size(183, 34);
            button2.TabIndex = 14;
            button2.Text = "Create an account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 707);
            button3.Name = "button3";
            button3.Size = new Size(183, 34);
            button3.TabIndex = 15;
            button3.Text = "Log in\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 665);
            label7.Name = "label7";
            label7.Size = new Size(254, 29);
            label7.TabIndex = 16;
            label7.Text = "sign up or login for discounts\r\n";
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(229, 167);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(0, 25);
            LabelID.TabIndex = 17;
            // 
            // AirlineHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 779);
            Controls.Add(LabelID);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AirlineHome";
            Text = "AirlineHome";
            Load += AirlineHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private Label LabelID;
    }
}