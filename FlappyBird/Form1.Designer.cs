namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.candy = new System.Windows.Forms.PictureBox();
            this.TNT = new System.Windows.Forms.PictureBox();
            this.loc = new System.Windows.Forms.PictureBox();
            this.flappy2 = new System.Windows.Forms.PictureBox();
            this.highest_score = new System.Windows.Forms.Label();
            this.loc2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.flappyLocation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, -2);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(141, 44);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(12, 738);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1843, 50);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(541, 12);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(152, 210);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 2;
            this.PipeTop.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(473, 510);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(149, 222);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 1;
            this.PipeBottom.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(57, 336);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(96, 66);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeTop2.Location = new System.Drawing.Point(1089, 12);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(152, 210);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 5;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipeBottom2.Location = new System.Drawing.Point(1005, 510);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(149, 222);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 6;
            this.pipeBottom2.TabStop = false;
            // 
            // candy
            // 
            this.candy.Image = ((System.Drawing.Image)(resources.GetObject("candy.Image")));
            this.candy.Location = new System.Drawing.Point(1265, 510);
            this.candy.Name = "candy";
            this.candy.Size = new System.Drawing.Size(95, 55);
            this.candy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candy.TabIndex = 7;
            this.candy.TabStop = false;
            this.candy.Visible = false;
            // 
            // TNT
            // 
            this.TNT.Image = ((System.Drawing.Image)(resources.GetObject("TNT.Image")));
            this.TNT.Location = new System.Drawing.Point(1189, 396);
            this.TNT.Name = "TNT";
            this.TNT.Size = new System.Drawing.Size(95, 55);
            this.TNT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TNT.TabIndex = 8;
            this.TNT.TabStop = false;
            this.TNT.Visible = false;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(1159, 494);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(100, 50);
            this.loc.TabIndex = 9;
            this.loc.TabStop = false;
            this.loc.Visible = false;
            // 
            // flappy2
            // 
            this.flappy2.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappy2.Location = new System.Drawing.Point(221, 365);
            this.flappy2.Name = "flappy2";
            this.flappy2.Size = new System.Drawing.Size(96, 66);
            this.flappy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappy2.TabIndex = 10;
            this.flappy2.TabStop = false;
            this.flappy2.Visible = false;
            // 
            // highest_score
            // 
            this.highest_score.AutoSize = true;
            this.highest_score.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highest_score.Location = new System.Drawing.Point(215, 12);
            this.highest_score.Name = "highest_score";
            this.highest_score.Size = new System.Drawing.Size(158, 25);
            this.highest_score.TabIndex = 11;
            this.highest_score.Text = "Higest scoer: 0";
            // 
            // loc2
            // 
            this.loc2.Location = new System.Drawing.Point(820, 419);
            this.loc2.Name = "loc2";
            this.loc2.Size = new System.Drawing.Size(100, 50);
            this.loc2.TabIndex = 12;
            this.loc2.TabStop = false;
            this.loc2.Visible = false;
            // 
            // life1
            // 
            this.life1.Image = ((System.Drawing.Image)(resources.GetObject("life1.Image")));
            this.life1.Location = new System.Drawing.Point(20, 45);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(96, 66);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life1.TabIndex = 13;
            this.life1.TabStop = false;
            // 
            // life3
            // 
            this.life3.Image = ((System.Drawing.Image)(resources.GetObject("life3.Image")));
            this.life3.Location = new System.Drawing.Point(221, 45);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(96, 66);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life3.TabIndex = 14;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = ((System.Drawing.Image)(resources.GetObject("life2.Image")));
            this.life2.Location = new System.Drawing.Point(122, 45);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(96, 66);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life2.TabIndex = 15;
            this.life2.TabStop = false;
            // 
            // flappyLocation
            // 
            this.flappyLocation.Location = new System.Drawing.Point(53, 336);
            this.flappyLocation.Name = "flappyLocation";
            this.flappyLocation.Size = new System.Drawing.Size(100, 66);
            this.flappyLocation.TabIndex = 16;
            this.flappyLocation.TabStop = false;
            this.flappyLocation.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1841, 790);
            this.Controls.Add(this.flappyLocation);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.loc2);
            this.Controls.Add(this.highest_score);
            this.Controls.Add(this.flappy2);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.TNT);
            this.Controls.Add(this.candy);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUP);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox candy;
        private System.Windows.Forms.PictureBox TNT;
        private System.Windows.Forms.PictureBox loc;
        private System.Windows.Forms.PictureBox flappy2;
        private System.Windows.Forms.Label highest_score;
        private System.Windows.Forms.PictureBox loc2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox flappyLocation;
    }
}

