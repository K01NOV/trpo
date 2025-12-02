using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private Form2 listFormInstance = null;
        public int checkNegative(string text)
        {
            if (int.TryParse(text, out int value))
            {
                return Math.Max(0, value);
            }
            return 0;
        }

        public string less50(TextBox textBox)
        {
            int.TryParse(textBox.Text, out int amount);
            if (amount > 50)
            {
                amount = 0;
            }
            return amount.ToString();
        }

        public void updateData()
        {
            int latinCount = checkNegative(latin.Text);
            int digitsCount = checkNegative(digits.Text);
            int specialCount = checkNegative(special.Text);
            int amountCount = latinCount + digitsCount + specialCount;
            if(amountCount > 50)
            {
                amountCount = 50;
                latinCount = 50;
                digitsCount = 0;
                specialCount = 0;
            }

            amount.Text = Convert.ToString(amountCount);
            latin.Text = Convert.ToString(latinCount);
            digits.Text = Convert.ToString(digitsCount);
            special.Text = Convert.ToString(specialCount);
        }

        public void autofill()
        {
            int latinCount = checkNegative(latin.Text);
            int digitsCount = checkNegative(digits.Text);
            int specialCount = checkNegative(special.Text);
            int amountCount = checkNegative(amount.Text);
            if (latinCount == 0 && amountCount > 0)
            {
                latinCount = amountCount - specialCount - digitsCount;
                latinCount = checkNegative(latinCount.ToString());
            }
            else if (digitsCount == 0 && amountCount > 0)
            {
                digitsCount = amountCount - latinCount - specialCount;
                digitsCount = checkNegative(digitsCount.ToString());
            }
            else if (specialCount == 0 && amountCount > 0)
            {
                specialCount = amountCount - digitsCount - latinCount;
                specialCount = checkNegative(specialCount.ToString());
            }
            latin.Text = Convert.ToString(latinCount);
            digits.Text = Convert.ToString(digitsCount);
            special.Text = Convert.ToString(specialCount);
        }

        public string generatePassword(int amount, int latin, int digits, int special)
        {
            string latinPattern = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digitPattern = "0123456789";
            string specialPattern = "[!@#$%^&*()]";
            string password = "";

            int position = 0;

            char[] pass = new char[amount];

            Random random = new Random();

            for (int i = 0; i < latin; i++)
            {
                Console.WriteLine(position);
                int index = random.Next(0, latinPattern.Length);
                pass[position] = latinPattern[index];
                position++;
            }

            for (int i = 0; i < digits; i++)
            {
                Console.WriteLine(position);
                int index = random.Next(0, digitPattern.Length);
                pass[position] = digitPattern[index];
                position++;
            }

            for (int i = 0; i < special; i++)
            {
                Console.WriteLine(position);
                int index = random.Next(0, specialPattern.Length);
                pass[position] = specialPattern[index];
                position++;
            }

            int n = pass.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                char temp = pass[n];
                pass[n] = pass[k];
                pass[k] = temp;
            }

            return new string(pass);
        }

        public Form1()
        {
            InitializeComponent();          
            
        }

        private void gen_Click(object sender, EventArgs e)
        {
            if (this.listFormInstance == null || this.listFormInstance.IsDisposed)
            {
                this.listFormInstance = new Form2();
            }
            autofill();
            updateData();

            int latinCount = checkNegative(latin.Text);
            int digitsCount = checkNegative(digits.Text);
            int specialCount = checkNegative(special.Text);
            int amountCount = checkNegative(amount.Text);

            string password = generatePassword(amountCount, latinCount, digitsCount, specialCount);
            pass.Text = password;
            this.listFormInstance.listBox1.Items.Add(password);
            this.listFormInstance.Show();
            this.listFormInstance.BringToFront();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if(pass.Text != "")
            {
                string password = pass.Text;
                Clipboard.SetText(password);
            }
        }

        private void amount_Leave(object sender, EventArgs e)
        {
            amount.Text = less50(amount);
        }

        private void latin_Leave(object sender, EventArgs e)
        {
            latin.Text = less50(latin);
        }

        private void digits_Leave(object sender, EventArgs e)
        {
            digits.Text = less50(digits);
        }

        private void special_Leave(object sender, EventArgs e)
        {
            special.Text = less50(special);
        }
    }
}
