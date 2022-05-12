
namespace Puzzle_Lavinia_Obrenovici
{
    partial class Clasament
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
            this.listaClasament = new System.Windows.Forms.ListBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaClasament
            // 
            this.listaClasament.FormattingEnabled = true;
            this.listaClasament.ItemHeight = 15;
            this.listaClasament.Location = new System.Drawing.Point(131, 57);
            this.listaClasament.Name = "listaClasament";
            this.listaClasament.Size = new System.Drawing.Size(557, 274);
            this.listaClasament.TabIndex = 0;
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStergere.Location = new System.Drawing.Point(283, 348);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(258, 65);
            this.btnStergere.TabIndex = 1;
            this.btnStergere.Text = "STERGERE";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // Clasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Puzzle_Lavinia_Obrenovici.Properties.Resources.ranking;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaClasament);
            this.Controls.Add(this.btnStergere);
            this.Name = "Clasament";
            this.Text = "Clasament";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaClasament;
        private System.Windows.Forms.Button btnStergere;
    }
}