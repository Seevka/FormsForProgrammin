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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                panel1.Left -= 5;
                if (panel1.Left <= ClientRectangle.Left)
                {
                    panel1.Left += 10;
                }
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                panel1.Left += 5;
                if (panel1.Right >= ClientRectangle.Right)
                {
                    panel1.Left -= 10;
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                panel1.Top -= 5;
                if (panel1.Top <= ClientRectangle.Top)
                {
                    panel1.Top += 10;
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                panel1.Top += 5;
                if (panel1.Bottom >= ClientRectangle.Bottom)
                {
                    panel1.Top -= 10;
                }
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
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
