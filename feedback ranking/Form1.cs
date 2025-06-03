using System;
using System.Windows.Forms;

namespace feedback_ranking
{
    public partial class Form1 : Form
    {
        private int selectedRating = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectRating(1, pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SelectRating(2, pictureBox2);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            SelectRating(3, pictureBox3);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            SelectRating(4, pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SelectRating(5, pictureBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string feedback = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();

            if (selectedRating == 0)
            {
                MessageBox.Show("Please select a rating.");
                return;
            }

            if (string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Please enter feedback.");
                return;
            }

            // Example: Display feedback summary
            MessageBox.Show($"Rating: {selectedRating}\nFeedback: {feedback}\nEmail: {email}", "Thank you!");

            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            selectedRating = 0;

            // Reset borders
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
        }

        private void SelectRating(int rating, PictureBox selectedBox)
        {
            selectedRating = rating;

            // Reset all borders
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;

            // Highlight selected one
            selectedBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
