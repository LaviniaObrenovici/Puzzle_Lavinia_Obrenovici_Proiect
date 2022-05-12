
namespace Puzzle_Lavinia_Obrenovici
{
    partial class Joc4Piese
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
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnShufflePiese = new System.Windows.Forms.Button();
            this.btnPauseGame = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.lblMovesMadeGame = new System.Windows.Forms.Label();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.p4);
            this.gb2.Controls.Add(this.p3);
            this.gb2.Controls.Add(this.p2);
            this.gb2.Controls.Add(this.p1);
            this.gb2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb2.Location = new System.Drawing.Point(12, 12);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(427, 441);
            this.gb2.TabIndex = 0;
            this.gb2.TabStop = false;
            this.gb2.Text = "Puzzle Game Imagini";
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(212, 228);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(200, 200);
            this.p4.TabIndex = 3;
            this.p4.TabStop = false;
            this.p4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(6, 228);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(200, 200);
            this.p3.TabIndex = 2;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(212, 22);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(200, 200);
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(6, 22);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(200, 200);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Puzzle_Lavinia_Obrenovici.Properties.Resources.original;
            this.groupBox2.Location = new System.Drawing.Point(486, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(599, 374);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(169, 44);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnShufflePiese
            // 
            this.btnShufflePiese.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShufflePiese.Location = new System.Drawing.Point(503, 424);
            this.btnShufflePiese.Name = "btnShufflePiese";
            this.btnShufflePiese.Size = new System.Drawing.Size(117, 42);
            this.btnShufflePiese.TabIndex = 3;
            this.btnShufflePiese.Text = "Shuffle";
            this.btnShufflePiese.UseVisualStyleBackColor = true;
            this.btnShufflePiese.Click += new System.EventHandler(this.btnShufflePiese_Click);
            // 
            // btnPauseGame
            // 
            this.btnPauseGame.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPauseGame.Location = new System.Drawing.Point(638, 424);
            this.btnPauseGame.Name = "btnPauseGame";
            this.btnPauseGame.Size = new System.Drawing.Size(104, 42);
            this.btnPauseGame.TabIndex = 4;
            this.btnPauseGame.Text = "Pause";
            this.btnPauseGame.UseVisualStyleBackColor = true;
            this.btnPauseGame.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExitGame.Location = new System.Drawing.Point(770, 424);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(81, 42);
            this.btnExitGame.TabIndex = 5;
            this.btnExitGame.Text = "Exit";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // lblMovesMadeGame
            // 
            this.lblMovesMadeGame.AutoSize = true;
            this.lblMovesMadeGame.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMovesMadeGame.Location = new System.Drawing.Point(18, 456);
            this.lblMovesMadeGame.Name = "lblMovesMadeGame";
            this.lblMovesMadeGame.Size = new System.Drawing.Size(157, 27);
            this.lblMovesMadeGame.TabIndex = 6;
            this.lblMovesMadeGame.Text = "Moves Made :";
            // 
            // Joc4Piese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Puzzle_Lavinia_Obrenovici.Properties.Resources.bamboobackground;
            this.ClientSize = new System.Drawing.Size(916, 519);
            this.Controls.Add(this.lblMovesMadeGame);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnPauseGame);
            this.Controls.Add(this.btnShufflePiese);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb2);
            this.Name = "Joc4Piese";
            this.Text = "Joc4Piese";
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnShufflePiese;
        private System.Windows.Forms.Button btnPauseGame;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Label lblMovesMadeGame;
    }
}