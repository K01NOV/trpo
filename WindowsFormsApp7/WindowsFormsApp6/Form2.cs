using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {

        public class ListItem
        {
            public string text { get; set; }

            public bool error { get; set; }

            public override string ToString()
            {
                return text;
            }
        }

        public void AddItem(string text, bool error)
        {
            this.listBox1.Items.Add(new ListItem
            {
                text = text,
                error = error
            });
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListItem listItem = (ListItem)listBox1.Items[e.Index];
            Brush textBrush;
            if (listItem.error)
            {
                textBrush = Brushes.Red;
            }
            else
            {
                textBrush = Brushes.Green;
            }

            e.Graphics.DrawString(listItem.text, e.Font, textBrush, e.Bounds.X, e.Bounds.Y);
        }
    }
}
