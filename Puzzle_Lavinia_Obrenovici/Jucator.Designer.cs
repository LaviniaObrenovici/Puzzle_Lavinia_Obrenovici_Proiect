
namespace Puzzle_Lavinia_Obrenovici
{
    partial class Jucator
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
            this.btnJocNou = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJocNou
            // 
            this.btnJocNou.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJocNou.Location = new System.Drawing.Point(265, 91);
            this.btnJocNou.Name = "btnJocNou";
            this.btnJocNou.Size = new System.Drawing.Size(231, 77);
            this.btnJocNou.TabIndex = 0;
            this.btnJocNou.Text = "JOC NOU";
            this.btnJocNou.UseVisualStyleBackColor = true;
            this.btnJocNou.Click += new System.EventHandler(this.btnJocNou_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(265, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLASAMENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(265, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "IESIRE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Jucator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Puzzle_Lavinia_Obrenovici.Properties.Resources.joc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJocNou);
            this.Name = "Jucator";
            this.Text = "Jucator";
            this.Load += new System.EventHandler(this.Jucator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJocNou;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}