using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace FormsForProgrammin
{
    public partial class Form11 : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public Form11()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
            button10.Text = richTextBox1.Font.Name + " " + richTextBox1.Font.Size;
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
            button10.Text = richTextBox1.Font.Name + " " + richTextBox1.Font.Size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            size += 1;
            richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, size);
            button10.Text = richTextBox1.Font.Name + " " + richTextBox1.Font.Size;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            size -= 1;
            richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, size);
            button10.Text = richTextBox1.Font.Name + " " + richTextBox1.Font.Size;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                richTextBox1.Text = richTextBox1.Text.ToLower();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Text = richTextBox1.Text.ToUpper();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
                richTextBox1.Focus();
            }
            else
            {
                richTextBox1.Focus();
            }
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int words = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            label2.Text = words.ToString();
            int countt = richTextBox1.Text.Length;
            string withoutSpaces = richTextBox1.Text.Replace(" ", "");
            label1.Text = countt.ToString() + "/" + withoutSpaces.Length;


        }
        private void Form11_Activated(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void відкритиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Sevka\source\repos\Crypta\Crypta",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt)|*.txt|png files (*.rft)|*.rtf|all files (*.*)|*.*",
                DefaultExt = ".txt",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                richTextBox1.Text = fileText;
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
            MessageBox.Show(
        "       Успішно збережено!",
        ""
        );
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (File.Create(sfd.FileName)) ;
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
            }
            MessageBox.Show(
        "       Успішно збережено!",
        ""
        );
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void друкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
            button10.Text = richTextBox1.Font.Name + " " + richTextBox1.Font.Size;
        }

        private void колірТекстуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void колірВиділенняТекстуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics objGraphics;
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf
                    = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void виділитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void кількістьСлівToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            label3.Text = (line+1).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void відмінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string userAnswer = Interaction.InputBox("Введіть, будь ласка, слово для пошуку", "Пошук");
            int start = 0;
            int end = richTextBox1.Text.LastIndexOf(userAnswer);

            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;

            while (start < end)
            {
                richTextBox1.Find(userAnswer, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);

                richTextBox1.SelectionBackColor = Color.Yellow;

                start = richTextBox1.Text.IndexOf(userAnswer, start) + 1;
            }
        }

    }
}
