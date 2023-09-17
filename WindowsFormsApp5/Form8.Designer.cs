namespace WindowsFormsApp5
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.Player = new System.Windows.Forms.PictureBox();
            this.E1 = new System.Windows.Forms.PictureBox();
            this.E2 = new System.Windows.Forms.PictureBox();
            this.E3 = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(6, 465);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(96, 77);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // E1
            // 
            this.E1.Image = ((System.Drawing.Image)(resources.GetObject("E1.Image")));
            this.E1.Location = new System.Drawing.Point(12, 12);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(90, 61);
            this.E1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E1.TabIndex = 1;
            this.E1.TabStop = false;
            // 
            // E2
            // 
            this.E2.Image = ((System.Drawing.Image)(resources.GetObject("E2.Image")));
            this.E2.Location = new System.Drawing.Point(270, 26);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(86, 64);
            this.E2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E2.TabIndex = 2;
            this.E2.TabStop = false;
            // 
            // E3
            // 
            this.E3.Image = ((System.Drawing.Image)(resources.GetObject("E3.Image")));
            this.E3.Location = new System.Drawing.Point(555, 26);
            this.E3.Name = "E3";
            this.E3.Size = new System.Drawing.Size(92, 64);
            this.E3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E3.TabIndex = 3;
            this.E3.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.Image = ((System.Drawing.Image)(resources.GetObject("Bullet.Image")));
            this.Bullet.Location = new System.Drawing.Point(325, 408);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(7, 27);
            this.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bullet.TabIndex = 4;
            this.Bullet.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SCORE:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "GO BACK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(718, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.E3);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.Player);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox E1;
        private System.Windows.Forms.PictureBox E2;
        private System.Windows.Forms.PictureBox E3;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}