
namespace FormsForProgrammin
{
    partial class Form13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.seconds = new System.Windows.Forms.PictureBox();
            this.dots = new System.Windows.Forms.PictureBox();
            this.minutes = new System.Windows.Forms.PictureBox();
            this.hours = new System.Windows.Forms.PictureBox();
            this.theme = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme)).BeginInit();
            this.SuspendLayout();
            // 
            // seconds
            // 
            this.seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seconds.BackColor = System.Drawing.Color.Transparent;
            this.seconds.Location = new System.Drawing.Point(384, 124);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(300, 300);
            this.seconds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seconds.TabIndex = 9;
            this.seconds.TabStop = false;
            this.seconds.Click += new System.EventHandler(this.secondBox_Click);
            // 
            // dots
            // 
            this.dots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dots.BackColor = System.Drawing.Color.Transparent;
            this.dots.Location = new System.Drawing.Point(268, 101);
            this.dots.Name = "dots";
            this.dots.Size = new System.Drawing.Size(300, 300);
            this.dots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dots.TabIndex = 8;
            this.dots.TabStop = false;
            this.dots.Click += new System.EventHandler(this.dotBox_Click);
            // 
            // minutes
            // 
            this.minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minutes.BackColor = System.Drawing.Color.Transparent;
            this.minutes.Location = new System.Drawing.Point(210, 69);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(300, 300);
            this.minutes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minutes.TabIndex = 7;
            this.minutes.TabStop = false;
            this.minutes.Click += new System.EventHandler(this.minuteBox_Click);
            // 
            // hours
            // 
            this.hours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hours.BackColor = System.Drawing.Color.Transparent;
            this.hours.Location = new System.Drawing.Point(142, 44);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(300, 300);
            this.hours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hours.TabIndex = 6;
            this.hours.TabStop = false;
            this.hours.Click += new System.EventHandler(this.hourBox_Click);
            // 
            // theme
            // 
            this.theme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theme.BackColor = System.Drawing.Color.Transparent;
            this.theme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theme.BackgroundImage")));
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme.Location = new System.Drawing.Point(117, 26);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(300, 300);
            this.theme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theme.TabIndex = 5;
            this.theme.TabStop = false;
            this.theme.Click += new System.EventHandler(this.backBox_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 476);
            this.button1.MaximumSize = new System.Drawing.Size(200, 200);
            this.button1.MinimumSize = new System.Drawing.Size(125, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поміняти фон годинника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form13
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(667, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.dots);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.theme);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "Form13";
            this.Text = "Годинник";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox seconds;
        private System.Windows.Forms.PictureBox dots;
        private System.Windows.Forms.PictureBox minutes;
        private System.Windows.Forms.PictureBox hours;
        private System.Windows.Forms.PictureBox theme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}