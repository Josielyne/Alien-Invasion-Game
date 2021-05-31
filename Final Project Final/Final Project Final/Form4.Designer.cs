namespace Final_Project_Final
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.ScoreBox = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Heart1 = new System.Windows.Forms.PictureBox();
            this.Heart3 = new System.Windows.Forms.PictureBox();
            this.Heart2 = new System.Windows.Forms.PictureBox();
            this.Alien1 = new System.Windows.Forms.PictureBox();
            this.Alien3 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.Alien2 = new System.Windows.Forms.PictureBox();
            this.FinalScore = new System.Windows.Forms.Label();
            this.GameOverBox = new System.Windows.Forms.Label();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Resume = new System.Windows.Forms.Label();
            this.Bullet2 = new System.Windows.Forms.PictureBox();
            this.Shooter = new System.Windows.Forms.PictureBox();
            this.AlienSpaceship1 = new System.Windows.Forms.PictureBox();
            this.Shooter2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlienSpaceship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shooter2)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreBox
            // 
            this.ScoreBox.AutoSize = true;
            this.ScoreBox.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBox.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ScoreBox.Location = new System.Drawing.Point(12, 9);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(83, 27);
            this.ScoreBox.TabIndex = 8;
            this.ScoreBox.Text = "Score:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Score.Location = new System.Drawing.Point(91, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(25, 27);
            this.Score.TabIndex = 9;
            this.Score.Text = "0";
            // 
            // Heart1
            // 
            this.Heart1.BackColor = System.Drawing.Color.Transparent;
            this.Heart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heart1.BackgroundImage")));
            this.Heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart1.Location = new System.Drawing.Point(138, 0);
            this.Heart1.Name = "Heart1";
            this.Heart1.Size = new System.Drawing.Size(86, 61);
            this.Heart1.TabIndex = 10;
            this.Heart1.TabStop = false;
            // 
            // Heart3
            // 
            this.Heart3.BackColor = System.Drawing.Color.Transparent;
            this.Heart3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heart3.BackgroundImage")));
            this.Heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart3.Location = new System.Drawing.Point(206, 0);
            this.Heart3.Name = "Heart3";
            this.Heart3.Size = new System.Drawing.Size(86, 61);
            this.Heart3.TabIndex = 11;
            this.Heart3.TabStop = false;
            // 
            // Heart2
            // 
            this.Heart2.BackColor = System.Drawing.Color.Transparent;
            this.Heart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heart2.BackgroundImage")));
            this.Heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart2.Location = new System.Drawing.Point(266, 0);
            this.Heart2.Name = "Heart2";
            this.Heart2.Size = new System.Drawing.Size(86, 61);
            this.Heart2.TabIndex = 12;
            this.Heart2.TabStop = false;
            // 
            // Alien1
            // 
            this.Alien1.BackColor = System.Drawing.Color.Transparent;
            this.Alien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alien1.BackgroundImage")));
            this.Alien1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alien1.Location = new System.Drawing.Point(416, -7);
            this.Alien1.Name = "Alien1";
            this.Alien1.Size = new System.Drawing.Size(52, 68);
            this.Alien1.TabIndex = 13;
            this.Alien1.TabStop = false;
            // 
            // Alien3
            // 
            this.Alien3.BackColor = System.Drawing.Color.Transparent;
            this.Alien3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alien3.BackgroundImage")));
            this.Alien3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alien3.Location = new System.Drawing.Point(645, 79);
            this.Alien3.Name = "Alien3";
            this.Alien3.Size = new System.Drawing.Size(52, 68);
            this.Alien3.TabIndex = 15;
            this.Alien3.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Menu.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(681, 8);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(45, 17);
            this.Menu.TabIndex = 16;
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pause.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(747, 8);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(49, 17);
            this.Pause.TabIndex = 17;
            this.Pause.Text = "Pause";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Alien2
            // 
            this.Alien2.BackColor = System.Drawing.Color.Transparent;
            this.Alien2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alien2.BackgroundImage")));
            this.Alien2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alien2.Location = new System.Drawing.Point(146, 200);
            this.Alien2.Name = "Alien2";
            this.Alien2.Size = new System.Drawing.Size(52, 68);
            this.Alien2.TabIndex = 18;
            this.Alien2.TabStop = false;
            // 
            // FinalScore
            // 
            this.FinalScore.AutoSize = true;
            this.FinalScore.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.FinalScore.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScore.Location = new System.Drawing.Point(441, 255);
            this.FinalScore.Name = "FinalScore";
            this.FinalScore.Size = new System.Drawing.Size(27, 30);
            this.FinalScore.TabIndex = 20;
            this.FinalScore.Text = "0";
            // 
            // GameOverBox
            // 
            this.GameOverBox.AutoSize = true;
            this.GameOverBox.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.GameOverBox.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverBox.Location = new System.Drawing.Point(109, 255);
            this.GameOverBox.Name = "GameOverBox";
            this.GameOverBox.Size = new System.Drawing.Size(647, 30);
            this.GameOverBox.TabIndex = 21;
            this.GameOverBox.Text = "GAME OVER! Your Score Is:           Click To Play Again!";
            this.GameOverBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverBox.Click += new System.EventHandler(this.GameOverBox_Click_1);
            // 
            // Bullet
            // 
            this.Bullet.BackColor = System.Drawing.Color.Transparent;
            this.Bullet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bullet.BackgroundImage")));
            this.Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bullet.Location = new System.Drawing.Point(357, 384);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(14, 26);
            this.Bullet.TabIndex = 22;
            this.Bullet.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Resume
            // 
            this.Resume.AutoSize = true;
            this.Resume.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Resume.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.Location = new System.Drawing.Point(352, 255);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(105, 30);
            this.Resume.TabIndex = 24;
            this.Resume.Text = "Resume";
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Bullet2
            // 
            this.Bullet2.BackColor = System.Drawing.Color.Transparent;
            this.Bullet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bullet2.BackgroundImage")));
            this.Bullet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bullet2.Location = new System.Drawing.Point(169, 384);
            this.Bullet2.Name = "Bullet2";
            this.Bullet2.Size = new System.Drawing.Size(14, 26);
            this.Bullet2.TabIndex = 26;
            this.Bullet2.TabStop = false;
            // 
            // Shooter
            // 
            this.Shooter.BackColor = System.Drawing.Color.Transparent;
            this.Shooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Shooter.BackgroundImage")));
            this.Shooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shooter.Location = new System.Drawing.Point(319, 404);
            this.Shooter.Name = "Shooter";
            this.Shooter.Size = new System.Drawing.Size(98, 122);
            this.Shooter.TabIndex = 27;
            this.Shooter.TabStop = false;
            // 
            // AlienSpaceship1
            // 
            this.AlienSpaceship1.BackColor = System.Drawing.Color.Transparent;
            this.AlienSpaceship1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlienSpaceship1.BackgroundImage")));
            this.AlienSpaceship1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlienSpaceship1.Location = new System.Drawing.Point(614, 26);
            this.AlienSpaceship1.Name = "AlienSpaceship1";
            this.AlienSpaceship1.Size = new System.Drawing.Size(182, 161);
            this.AlienSpaceship1.TabIndex = 28;
            this.AlienSpaceship1.TabStop = false;
            // 
            // Shooter2
            // 
            this.Shooter2.BackColor = System.Drawing.Color.Transparent;
            this.Shooter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Shooter2.BackgroundImage")));
            this.Shooter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shooter2.Location = new System.Drawing.Point(126, 404);
            this.Shooter2.Name = "Shooter2";
            this.Shooter2.Size = new System.Drawing.Size(98, 122);
            this.Shooter2.TabIndex = 29;
            this.Shooter2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 515);
            this.Controls.Add(this.Shooter2);
            this.Controls.Add(this.Shooter);
            this.Controls.Add(this.FinalScore);
            this.Controls.Add(this.Alien1);
            this.Controls.Add(this.Bullet2);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Heart2);
            this.Controls.Add(this.Heart3);
            this.Controls.Add(this.Heart1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.GameOverBox);
            this.Controls.Add(this.Alien2);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Alien3);
            this.Controls.Add(this.AlienSpaceship1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlienSpaceship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shooter2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreBox;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Heart1;
        private System.Windows.Forms.PictureBox Heart3;
        private System.Windows.Forms.PictureBox Heart2;
        private System.Windows.Forms.PictureBox Alien1;
        private System.Windows.Forms.PictureBox Alien3;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.PictureBox Alien2;
        private System.Windows.Forms.Label FinalScore;
        private System.Windows.Forms.Label GameOverBox;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Resume;
        private System.Windows.Forms.PictureBox Bullet2;
        private System.Windows.Forms.PictureBox Shooter;
        private System.Windows.Forms.PictureBox AlienSpaceship1;
        private System.Windows.Forms.PictureBox Shooter2;
    }
}