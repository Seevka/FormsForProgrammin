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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
            INIT();
        }
        Point point = new Point();

        private void Form9_Load(object sender, EventArgs e)
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
        public void INIT()
        {
            panel1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { point = Control.MousePosition; }
            };

            panel1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(point.X - temp.X, point.Y - temp.Y);
                    panel1.Location = new Point(panel1.Location.X - res.X, panel1.Location.Y - res.Y);

                    point = temp;
                }
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
