﻿namespace VirusEscape
{
    partial class Game
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.virusStartScreen = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.PlayerAnimate = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.virusStartScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(-3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(182, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Virus Escape";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(4, 12);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(164, 49);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // virusStartScreen
            // 
            this.virusStartScreen.Location = new System.Drawing.Point(4, 9);
            this.virusStartScreen.Name = "virusStartScreen";
            this.virusStartScreen.Size = new System.Drawing.Size(164, 148);
            this.virusStartScreen.TabIndex = 2;
            this.virusStartScreen.TabStop = false;
            // 
            // Player
            // 
            this.Player.Location = new System.Drawing.Point(472, 185);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(52, 50);
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // PlayerAnimate
            // 
            this.PlayerAnimate.Interval = 160;
            this.PlayerAnimate.Tick += new System.EventHandler(this.PlayerAnimate_Tick);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 20;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 421);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.virusStartScreen);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelTitle);
            this.Name = "Game";
            this.Text = "Virus Escape";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.virusStartScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox virusStartScreen;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer PlayerAnimate;
        private System.Windows.Forms.Timer MoveTimer;
    }
}

