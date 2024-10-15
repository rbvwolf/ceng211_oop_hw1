namespace CENG211Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                //int age = int.Parse(textBox1.Text);
                int age;
                if (int.TryParse(textBox1.Text, out age))
                {
                    if (age > 0 && age < 18)
                    {
                        MessageBox.Show("You are underage!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (age >= 18 && age <= 100)
                    {
                        MessageBox.Show("You are an adult!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (age > 100)
                    {
                        MessageBox.Show("Thats a long life huh?!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("No you are not " + age + " years old.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You have entered an invalid input.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
