using FibonacciNiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clsMathWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerisiFibonacci_Click_1(object sender, EventArgs e)
        {
            try
            {
                int broj = int.Parse(textBox1.Text);
                long[] fibonacciNiz = clsMath.GenFibonacci(broj);

                listBox1.Items.Clear();

                foreach (long v in fibonacciNiz)
                {
                    listBox1.Items.Add(v);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite ispravan broj.");
            }
        }
    }
}
