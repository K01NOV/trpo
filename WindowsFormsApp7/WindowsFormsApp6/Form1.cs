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

        public Form1()
        {
            InitializeComponent();          
            
        }

        public bool checkSeries(string series)
        {
            if(int.TryParse(series, out int s))
            {
                if(s >= 6901 && s <= 6904)
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkNumber(string number)
        {
            if (int.TryParse(number, out int n))
            {
                if (n >= 100000 && n <= 800000)
                {
                    return true;
                }
            }
            return false;
        }

        private void gen_Click(object sender, EventArgs e)
        {
            if (this.listFormInstance == null || this.listFormInstance.IsDisposed)
            {
                this.listFormInstance = new Form2();
            }
            string srs = series.Text;
            string num = number.Text;
            string data = srs + " " + num;
            
            if(!checkSeries(srs) || !checkNumber(num))
            {
                this.listFormInstance.AddItem(data, true);
            }
            else
            {
                this.listFormInstance.AddItem(data, false);
            }
                this.listFormInstance.Show();
            this.listFormInstance.BringToFront();
        }
    }
}
