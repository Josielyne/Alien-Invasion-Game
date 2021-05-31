namespace Final_Project_Final
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
            this.Start = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.AlienInvasion = new System.Windows.Forms.TextBox();
            this.Multiplayer = new System.Windows.Forms.Button();
            this.OneHandedMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Start.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(173, 279);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(132, 62);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Quit.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(489, 279);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(132, 62);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlienInvasion
            // 
            this.AlienInvasion.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AlienInvasion.Font = new System.Drawing.Font("Showcard Gothic", 43F);
            this.AlienInvasion.Location = new System.Drawing.Point(199, 59);
            this.AlienInvasion.Name = "AlienInvasion";
            this.AlienInvasion.Size = new System.Drawing.Size(432, 78);
            this.AlienInvasion.TabIndex = 2;
            this.AlienInvasion.Text = "Alien Invasion";
            // 
            // Multiplayer
            // 
            this.Multiplayer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Multiplayer.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplayer.Location = new System.Drawing.Point(116, 408);
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Size = new System.Drawing.Size(246, 62);
            this.Multiplayer.TabIndex = 3;
            this.Multiplayer.Text = "Multiplayer";
            this.Multiplayer.UseVisualStyleBackColor = false;
            this.Multiplayer.Click += new System.EventHandler(this.Multiplayer_Click);
            // 
            // OneHandedMode
            // 
            this.OneHandedMode.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.OneHandedMode.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneHandedMode.Location = new System.Drawing.Point(408, 408);
            this.OneHandedMode.Name = "OneHandedMode";
            this.OneHandedMode.Size = new System.Drawing.Size(281, 62);
            this.OneHandedMode.TabIndex = 4;
            this.OneHandedMode.Text = "1-Handed Mode";
            this.OneHandedMode.UseVisualStyleBackColor = false;
            this.OneHandedMode.Click += new System.EventHandler(this.OneHandedMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 515);
            this.Controls.Add(this.OneHandedMode);
            this.Controls.Add(this.Multiplayer);
            this.Controls.Add(this.AlienInvasion);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.TextBox AlienInvasion;
        private System.Windows.Forms.Button Multiplayer;
        private System.Windows.Forms.Button OneHandedMode;
    }
}

