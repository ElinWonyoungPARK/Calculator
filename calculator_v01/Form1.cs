using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_v01
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
            Button btnTmp = (Button)sender;
            textBox1.Text += btnTmp.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textBox1.Text.Split('+');
            
            double result = 0;

            for(int i = 0; i < plusSplit.Length; i++)
            {
                string[] minusSplit = plusSplit[i].Split('-');
                double minusSplitResult = 0;

                for (int j =0; j < minusSplit.Length; j++)
                {
                    if (j == 0)
                        minusSplitResult += Convert.ToDouble(minusSplit[j]);
                    else
                        minusSplitResult -= Convert.ToDouble(minusSplit[j]);
                }

                plusSplit[i] = Convert.ToString(minusSplitResult);

                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }

            label3.Text = Convert.ToString(result); // 라벨에 결과 표시
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label3.Text = string.Empty;
            this.textBox1.Text = string.Empty;
        }
    }
}
