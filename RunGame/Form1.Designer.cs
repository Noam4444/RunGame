namespace RunGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblScore = new Label();
            lblhighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            bt1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform_tilesblue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(883, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform_tilesblue;
            pictureBox2.Location = new Point(0, 392);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(883, 62);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.run_up0;
            player.Location = new Point(218, 38);
            player.Name = "player";
            player.Size = new Size(59, 74);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.box;
            pictureBox4.Location = new Point(589, 322);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 74);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.box;
            pictureBox5.Location = new Point(358, 54);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 74);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "obstacle";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(23, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(121, 38);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            // 
            // lblhighScore
            // 
            lblhighScore.AutoSize = true;
            lblhighScore.BackColor = Color.Transparent;
            lblhighScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblhighScore.ForeColor = Color.White;
            lblhighScore.Location = new Point(12, 403);
            lblhighScore.Name = "lblhighScore";
            lblhighScore.Size = new Size(192, 38);
            lblhighScore.TabIndex = 6;
            lblhighScore.Text = "High Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;

           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
           
            Controls.Add(lblScore);
            Controls.Add(lblhighScore);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(player);
            Name = "Form1";
            Text = "Gravity Run Game";
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblScore;
        private Label lblhighScore;
        private System.Windows.Forms.Timer gameTimer;
        private Button bt1;
    }
} 