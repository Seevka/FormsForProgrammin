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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }
        enum Move
        {
            Right,
            Left,
            Down,
            Up
        }
        Move now_move = Move.Up;

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (now_move)
            {
                case Move.Right:
                    if (button1.Location.X + button1.Width + 15 > Width - 15)
                        button1.Location = new Point(0, button1.Location.Y);
                    else
                        button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
                    break;
                case Move.Left:
                    if (button1.Location.X - 10 < 0)
                        button1.Location = new Point(this.Width - 15 - button1.Width, button1.Location.Y);
                    else
                        button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
                    break;
                case Move.Down:
                    if (button1.Location.Y + button1.Width >= Height)
                        button1.Location = new Point(button1.Location.X, 0);
                    else
                        button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
                    break;
                case Move.Up:
                    if (button1.Location.Y <= 0)
                        button1.Location = new Point(button1.Location.X, Height - 2 * button1.Height);
                    else
                        button1.Location = new Point(button1.Location.X, button1.Location.Y - 10);
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            now_move = Move.Right;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            now_move = Move.Left;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            now_move = Move.Down;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            now_move = Move.Up;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                timer1.Start();
            else if (checkBox1.Checked == false)
                timer1.Stop();
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    now_move = Move.Right;
                    radioButton1.Checked = true;
                    break;
                case Keys.Left:
                    now_move = Move.Left;
                    radioButton2.Checked = true;
                    break;
                case Keys.Down:
                    now_move = Move.Down;
                    radioButton3.Checked = true;
                    break;
                case Keys.Up:
                    now_move = Move.Up;
                    radioButton4.Checked = true;
                    break;
                case Keys.Space:
                    if (checkBox1.Checked = true)
                    {
                        checkBox1.Checked = false;
                        timer1.Stop();
                    }
                    break;
            }
            e.IsInputKey = true;
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
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
