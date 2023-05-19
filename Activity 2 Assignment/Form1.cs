using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2_Assignment
{
    public partial class MultiplyBy2 : Form
    {
        public MultiplyBy2()
        {
            InitializeComponent();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal answer;
                decimal userinput;

                userinput = int.Parse(MultiplyTextbox.Text);

                answer = Convert.ToInt32(userinput) * 2;
                AnswerLabel.Text = answer.ToString("n3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invaild input");
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MultiplyTextbox.Text = "";
            AnswerLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
