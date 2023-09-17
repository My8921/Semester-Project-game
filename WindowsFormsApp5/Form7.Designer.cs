namespace WindowsFormsApp5
{
    partial class Form7
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Runner = new System.Windows.Forms.PictureBox();
            this.OBS1 = new System.Windows.Forms.PictureBox();
            this.OBS2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Runner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBS2)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ground.Location = new System.Drawing.Point(-1, 372);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(801, 50);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Runner
            // 
            this.Runner.Image = global::WindowsFormsApp5.Properties.Resources.running;
            this.Runner.Location = new System.Drawing.Point(101, 308);
            this.Runner.Name = "Runner";
            this.Runner.Size = new System.Drawing.Size(71, 65);
            this.Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Runner.TabIndex = 1;
            this.Runner.TabStop = false;
            // 
            // OBS1
            // 
            this.OBS1.Image = global::WindowsFormsApp5.Properties.Resources.obstacle_1;
            this.OBS1.Location = new System.Drawing.Point(507, 323);
            this.OBS1.Name = "OBS1";
            this.OBS1.Size = new System.Drawing.Size(50, 50);
            this.OBS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OBS1.TabIndex = 2;
            this.OBS1.TabStop = false;
            this.OBS1.Tag = "obs";
            // 
            // OBS2
            // 
            this.OBS2.Image = global::WindowsFormsApp5.Properties.Resources.obstacle_2;
            this.OBS2.Location = new System.Drawing.Point(652, 308);
            this.OBS2.Name = "OBS2";
            this.OBS2.Size = new System.Drawing.Size(82, 65);
            this.OBS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OBS2.TabIndex = 3;
            this.OBS2.TabStop = false;
            this.OBS2.Tag = "obs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "GO BACK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OBS2);
            this.Controls.Add(this.OBS1);
            this.Controls.Add(this.Runner);
            this.Controls.Add(this.Ground);
            this.Name = "Form7";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Runner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Runner;
        private System.Windows.Forms.PictureBox OBS1;
        private System.Windows.Forms.PictureBox OBS2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}