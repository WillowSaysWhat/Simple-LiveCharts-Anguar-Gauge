namespace SimpleAngularGauge
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxVspeed = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpeed = new System.Windows.Forms.PictureBox();
            this.pictureBoxAltitude = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVspeed
            // 
            this.pictureBoxVspeed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVspeed.Image")));
            this.pictureBoxVspeed.Location = new System.Drawing.Point(149, 142);
            this.pictureBoxVspeed.Name = "pictureBoxVspeed";
            this.pictureBoxVspeed.Size = new System.Drawing.Size(192, 179);
            this.pictureBoxVspeed.TabIndex = 0;
            this.pictureBoxVspeed.TabStop = false;
            // 
            // pictureBoxSpeed
            // 
            this.pictureBoxSpeed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSpeed.Image")));
            this.pictureBoxSpeed.Location = new System.Drawing.Point(450, 142);
            this.pictureBoxSpeed.Name = "pictureBoxSpeed";
            this.pictureBoxSpeed.Size = new System.Drawing.Size(194, 179);
            this.pictureBoxSpeed.TabIndex = 1;
            this.pictureBoxSpeed.TabStop = false;
            // 
            // pictureBoxAltitude
            // 
            this.pictureBoxAltitude.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAltitude.Image")));
            this.pictureBoxAltitude.Location = new System.Drawing.Point(780, 142);
            this.pictureBoxAltitude.Name = "pictureBoxAltitude";
            this.pictureBoxAltitude.Size = new System.Drawing.Size(195, 179);
            this.pictureBoxAltitude.TabIndex = 2;
            this.pictureBoxAltitude.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStart.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(828, 371);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(147, 51);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(828, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1165, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxAltitude);
            this.Controls.Add(this.pictureBoxSpeed);
            this.Controls.Add(this.pictureBoxVspeed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVspeed;
        private System.Windows.Forms.PictureBox pictureBoxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxAltitude;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button1;
    }
}

