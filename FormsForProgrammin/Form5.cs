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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
            textBox1.Text += "Обіцяю що не буду списувати і грати в броул старс!";
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
