using System.Text.RegularExpressions;

namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            String var = textBox1.Text;
            String[] words = var.Split(' ');
            Regex intRegex = new Regex(@"^[+-]?[0-9]+$");  // integer
            Regex floatRegex = new Regex(@"^[+-]?[0-9]*[.][0-9]+([eE][+-]?[0-9]+)?$"); // float or scientific
            Regex charRegex = new Regex(@"^'[a-zA-Z0-9]'$"); // single character in quotes
            foreach (string word in words)
            {
                if (intRegex.IsMatch(word))
                {
                    textBox2.AppendText(word + " → Integer" + Environment.NewLine);
                }
                else if (floatRegex.IsMatch(word))
                {
                    textBox2.AppendText(word + " → Float" + Environment.NewLine);
                }
                else if (charRegex.IsMatch(word))
                {
                    textBox2.AppendText(word + " → Char" + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Invalid: " + word);
                }
            }
            }
        }

      
    }

