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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            label1.Text = index.ToString();
            textBox1.Text = index.ToString();
            comboBox1.SelectedIndex = index;
            this.Text = index.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            label1.Text = index1.ToString();
            textBox1.Text = index1.ToString();
            listBox1.SelectedIndex = index1;
            this.Text = index1.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("The window will be closed. Are u sure?", "Confirm the action",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;

            }
        }
    }
}
