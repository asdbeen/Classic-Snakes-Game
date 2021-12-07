using System;
using System.Windows.Forms;

namespace Classic_Snakes_Game
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
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SnapButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(566, 144);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score:0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(566, 186);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(90, 20);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "Highscore";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(570, 19);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(47, 37);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start);
            // 
            // SnapButton
            // 
            this.SnapButton.Location = new System.Drawing.Point(570, 71);
            this.SnapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SnapButton.Name = "SnapButton";
            this.SnapButton.Size = new System.Drawing.Size(47, 37);
            this.SnapButton.TabIndex = 4;
            this.SnapButton.Text = "snap";
            this.SnapButton.UseVisualStyleBackColor = true;
            this.SnapButton.Click += new System.EventHandler(this.Snap);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(21, 11);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(500, 600);
            this.picCanvas.TabIndex = 5;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePic);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 641);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.SnapButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Classic snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private Button StartButton;
        private Button SnapButton;
        private PictureBox picCanvas;
        private Timer GameTimer;
    }
}

