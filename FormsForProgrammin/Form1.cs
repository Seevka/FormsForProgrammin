using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsForProgrammin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 from2 = new Form2();
            from2.Activate();
            from2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Чи ви впевнені що хочете вийти?",
        "Увага!",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 from3 = new Form3();
            from3.Activate();
            from3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Activate();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Activate();
            frm6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Activate();
            frm7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Activate();
            frm8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Activate();
            frm9.Show();
        }
    }
}
