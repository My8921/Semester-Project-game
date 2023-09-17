namespace WindowsFormsApp5
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Award = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.track2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Track1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Explosion);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.Award);
            this.panel1.Controls.Add(this.Car1);
            this.panel1.Controls.Add(this.Car2);
            this.panel1.Controls.Add(this.track2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Track1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 436);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Explosion
            // 
            this.Explosion.Image = ((System.Drawing.Image)(resources.GetObject("Explosion.Image")));
            this.Explosion.Location = new System.Drawing.Point(63, 300);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Explosion.TabIndex = 8;
            this.Explosion.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(209, 348);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 7;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Award
            // 
            this.Award.Image = ((System.Drawing.Image)(resources.GetObject("Award.Image")));
            this.Award.Location = new System.Drawing.Point(119, 194);
            this.Award.Name = "Award";
            this.Award.Size = new System.Drawing.Size(250, 100);
            this.Award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Award.TabIndex = 6;
            this.Award.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(106, 0);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(50, 100);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car1.TabIndex = 4;
            this.Car1.TabStop = false;
            this.Car1.Tag = "left";
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(386, 30);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(50, 100);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            this.Car2.Tag = "right";
            // 
            // track2
            // 
            this.track2.Image = ((System.Drawing.Image)(resources.GetObject("track2.Image")));
            this.track2.Location = new System.Drawing.Point(0, 0);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(481, 436);
            this.track2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.track2.TabIndex = 3;
            this.track2.TabStop = false;
            this.track2.Click += new System.EventHandler(this.track2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 10);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Track1
            // 
            this.Track1.Image = ((System.Drawing.Image)(resources.GetObject("Track1.Image")));
            this.Track1.Location = new System.Drawing.Point(0, -400);
            this.Track1.Name = "Track1";
            this.Track1.Size = new System.Drawing.Size(496, 586);
            this.Track1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Track1.TabIndex = 0;
            this.Track1.TabStop = false;
            this.Track1.Click += new System.EventHandler(this.Track1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE:0";
            // 
            // Game
            // 
            this.Game.Enabled = true;
            this.Game.Interval = 20;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "GO BACK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(480, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Track1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox track2;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Award;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
    }
}