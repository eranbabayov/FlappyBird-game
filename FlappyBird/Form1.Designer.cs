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
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.candy = new System.Windows.Forms.PictureBox();
            this.TNT = new System.Windows.Forms.PictureBox();
            this.loc = new System.Windows.Forms.PictureBox();
            this.flappy2 = new System.Windows.Forms.PictureBox();
            this.highest_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, -2);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(176, 55);
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
            // PipeBottom
            // 
            this.PipeBottom.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeBottom.Location = new System.Drawing.Point(541, 12);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(152, 210);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 2;
            this.PipeBottom.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.pipe;
            this.PipeTop.Location = new System.Drawing.Point(473, 510);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(149, 222);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 1;
            this.PipeTop.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(35, 336);
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
            this.loc.Location = new System.Drawing.Point(897, 446);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(100, 50);
            this.loc.TabIndex = 9;
            this.loc.TabStop = false;
            this.loc.Visible = false;
            // 
            // flappy2
            // 
            this.flappy2.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappy2.Location = new System.Drawing.Point(319, 375);
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
            this.highest_score.Size = new System.Drawing.Size(200, 32);
            this.highest_score.TabIndex = 11;
            this.highest_score.Text = "Higest scoer: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1841, 790);
            this.Controls.Add(this.highest_score);
            this.Controls.Add(this.flappy2);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.TNT);
            this.Controls.Add(this.candy);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUP);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeBottom;
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
    }
}

