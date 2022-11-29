using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataConversion
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

        private void button1_Click(object sender, EventArgs e)
        {
            convertfloat2TextBox(convertfloat2int(convertText2float(textBox1.Text)),ref textBox2);


        }
        public void convertfloat2TextBox(float sf, ref TextBox tx)
        {
            tx.Text = sf.ToString();
        }
        public float convertText2float(string s)
        {
           
            float f = Convert.ToSingle(s);
            return f;
        }
        public int convertText2int(string s)
        {

            int i = Convert.ToInt16(s);
            return i;
        }
        public int convertfloat2int(float x)
        {
            int r = (int)x;
            return r;
        }

        public float differenceFloat2Int(float f, int i)
        {
            return f - i;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            convertfloat2TextBox(differenceFloat2Int(convertText2float(textBox1.Text),convertText2int(textBox2.Text)),ref this.textBox3);

        }
    }
}
