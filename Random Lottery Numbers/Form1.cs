using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Lottery_Numbers
{
    public partial class Form1 : Form
    {
        Random randomGenerator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GenerateNumber().ToString();
            textBox2.Text = GenerateNumber().ToString();
            textBox3.Text = GenerateNumber().ToString();
            textBox4.Text = GenerateNumber().ToString();
            textBox5.Text = GenerateNumber().ToString();
            textBox6.Text = GenerateNumber().ToString();
        }

        private int GenerateNumber()
        {
            int number;
            number = randomGenerator.Next(1, 55);
            return number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate the numbers in each text box
            ValidateNumber(textBox1);
            ValidateNumber(textBox2);
            ValidateNumber(textBox3);
            ValidateNumber(textBox4);
            ValidateNumber(textBox5);
            ValidateNumber(textBox6);
        }
        private void ValidateNumber(TextBox textBox)
        {
            bool bValid = true;
            if (int.TryParse(textBox.Text, out int number))
            {
                if (number < 1 || number > 54)
                {
                    MessageBox.Show("Number out of range: " + number + ". Please enter a number between 1 and 54.");
                    bValid = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid input: " + textBox.Text + ". Please enter a numeric value.");
                bValid = false;
            }

            if(bValid == true)
            {
                MessageBox.Show("Good luck, Hurley!");
            }
        }
    }
}
