namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = "";
            t = textBox1.Text;
            richTextBox1.AppendText(t + "\n");
            t = comboBox1.Text;
            richTextBox1.AppendText(t + "\n");
            if (radioButton1.Checked) t += "Мужской \n";
            if (radioButton2.Checked) t += "Женский \n";
            richTextBox1.AppendText(t + "\n");
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}