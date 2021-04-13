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
    public partial class Form13 : Form
    {
        Bitmap back, hour, minute, dot, second;
        public Form13()
        {
            InitializeComponent();
            //back = new Bitmap(@"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\Без назви-2.png");
            hour = new Bitmap(@"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\hour.png");
            minute = new Bitmap(@"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\minute.png");
            dot = new Bitmap(@"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\dot.png");
            second = new Bitmap(@"C:\Users\Sevka\source\repos\FormsForProgrammin\FormsForProgrammin\second.png");
            this.FormClosing += new FormClosingEventHandler(Form13_Closing);
        }
        private void dotBox_Click(object sender, EventArgs e)
        {

        }

        private void minuteBox_Click(object sender, EventArgs e)
        {

        }


        private void secondBox_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
        private void Form13_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Sevka\Desktop\BrawlClock",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "png files (*.png)|*.png|all files (*.*)|*.*",
                DefaultExt = ".txt",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theme.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void hourBox_Click(object sender, EventArgs e)
        {

        }

        private void backBox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            //theme.Image = back;
            theme.Controls.Add(hours);
            hours.Location = new Point(0, 0);
            hours.Image = rotateImage(hour, AngleH);


            hours.Controls.Add(minutes);
            minutes.Location = new Point(0,0) ;
            minutes.Image = rotateImage(minute, AngleM);

            minutes.Controls.Add(dots);
            dots.Location = new Point(0, 0);
            dots.Image = dot;


            dots.Controls.Add(seconds);
            seconds.Location = new Point(0, 0);
            seconds.Image = rotateImage(second, AngleS);

        }

        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }

            return rotatedImage;
        }

    }
}
