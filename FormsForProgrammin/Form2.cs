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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
            textBox1.KeyPress += new KeyPressEventHandler(txtHomePhone_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(txtHomePhone_KeyPress);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYourTextBox_KeyDown);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYourTextBox_KeyDown);
            textBox1.Text = textBox1.Text.Replace(Environment.NewLine, "");
            textBox2.Text = textBox2.Text.Replace(Environment.NewLine, "");
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            redToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            blueToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            yellowToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;

            this.BackColor = Color.Red;
            label1.Font = new Font(label1.Font.FontFamily, 8);
            label2.Font = new Font(label1.Font.FontFamily, 8);
            label3.Font = new Font(label1.Font.FontFamily, 8);
        }
        public class CustomCheckBox : CheckBox
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtYourTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
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

        private void button3_Click(object sender, EventArgs e)
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
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.PointToScreen(e.Location));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;

            // Is Negative Number?
            if (e.KeyChar == '-' && text.Length == 0)
            {
                e.Handled = false;
                return;
            }

            // Is Float Number?
            if (e.KeyChar == ',' && text.Length > 0 && !text.Contains(","))
            {
                e.Handled = false;
                return;
            }

            // Is Digit?
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox3.Text += (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
            label2.Text += (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label2.Text = "";
        }


        private void exitF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maximizedToolStripMenuItem.Checked = false;
                maximaziToolStripMenuItem.Checked = false;
                checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                maximizedToolStripMenuItem.Checked = true;
                maximaziToolStripMenuItem.Checked = true;
                checkBox1.CheckState = CheckState.Checked;
            }
        }

        private void button2TextВиділитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button2.Text = "Поділити";
            }

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void windowStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3FontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            label1.Font = new Font(label1.Font.FontFamily, 8);
            label2.Font = new Font(label1.Font.FontFamily, 8);
            label3.Font = new Font(label1.Font.FontFamily, 8);
            radioButton1.Checked = true;



        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            label1.Font = new Font(label1.Font.FontFamily, 16);
            label2.Font = new Font(label1.Font.FontFamily, 16);
            label3.Font = new Font(label1.Font.FontFamily, 16);
            radioButton2.Checked = true;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            label1.Font = new Font(label1.Font.FontFamily, 24);
            label2.Font = new Font(label1.Font.FontFamily, 24);
            label3.Font = new Font(label1.Font.FontFamily, 24);
            radioButton3.Checked = true;
        }

        private void windowStateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitF10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       
                this.Close();
        }

        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maximizedToolStripMenuItem.Checked = false;
                maximaziToolStripMenuItem.Checked = false;
                checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                maximizedToolStripMenuItem.Checked = true;
                maximaziToolStripMenuItem.Checked = true;
                checkBox1.CheckState = CheckState.Checked;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            blueToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            yellowToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.BackColor = Color.Red;
            
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            blueToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            yellowToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.BackColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            blueToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            yellowToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            this.BackColor = Color.Yellow;
        }


        private void textDivideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button2.Text = "Divide";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizedToolStripMenuItem.Checked = true;
                maximaziToolStripMenuItem.Checked = true;
                checkBox1.CheckState = CheckState.Checked;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizedToolStripMenuItem.Checked = false;
                maximaziToolStripMenuItem.Checked = false;
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 8);
            label2.Font = new Font(label1.Font.FontFamily, 8);
            label3.Font = new Font(label1.Font.FontFamily, 8);
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 16);
            label2.Font = new Font(label1.Font.FontFamily, 16);
            label3.Font = new Font(label1.Font.FontFamily, 16);
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 24);
            label2.Font = new Font(label1.Font.FontFamily, 24);
            label3.Font = new Font(label1.Font.FontFamily, 24);
            toolStripMenuItem6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem8.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
