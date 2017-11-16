namespace Cocktailverwaltung
{
    partial class Getraenkeuebersicht
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
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.btn_neuesGetraenk = new System.Windows.Forms.Button();
            this.lbl_Getraenkeuebersicht = new System.Windows.Forms.Label();
            this.lbl_Getraenkenummer = new System.Windows.Forms.Label();
            this.txt_Getraenkenummer = new System.Windows.Forms.TextBox();
            this.btn_Verkaufen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Zurueck.Location = new System.Drawing.Point(743, 9);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(120, 50);
            this.btn_Zurueck.TabIndex = 12;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // btn_neuesGetraenk
            // 
            this.btn_neuesGetraenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_neuesGetraenk.Location = new System.Drawing.Point(359, 9);
            this.btn_neuesGetraenk.Name = "btn_neuesGetraenk";
            this.btn_neuesGetraenk.Size = new System.Drawing.Size(120, 50);
            this.btn_neuesGetraenk.TabIndex = 11;
            this.btn_neuesGetraenk.Text = "Neues Getränk";
            this.btn_neuesGetraenk.UseVisualStyleBackColor = true;
            // 
            // lbl_Getraenkeuebersicht
            // 
            this.lbl_Getraenkeuebersicht.AutoSize = true;
            this.lbl_Getraenkeuebersicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Getraenkeuebersicht.Location = new System.Drawing.Point(12, 9);
            this.lbl_Getraenkeuebersicht.Name = "lbl_Getraenkeuebersicht";
            this.lbl_Getraenkeuebersicht.Size = new System.Drawing.Size(341, 42);
            this.lbl_Getraenkeuebersicht.TabIndex = 10;
            this.lbl_Getraenkeuebersicht.Text = "Getränkeübersicht";
            // 
            // lbl_Getraenkenummer
            // 
            this.lbl_Getraenkenummer.AutoSize = true;
            this.lbl_Getraenkenummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Getraenkenummer.Location = new System.Drawing.Point(734, 82);
            this.lbl_Getraenkenummer.Name = "lbl_Getraenkenummer";
            this.lbl_Getraenkenummer.Size = new System.Drawing.Size(129, 16);
            this.lbl_Getraenkenummer.TabIndex = 13;
            this.lbl_Getraenkenummer.Text = "Getränkenummer:";
            // 
            // txt_Getraenkenummer
            // 
            this.txt_Getraenkenummer.Location = new System.Drawing.Point(737, 101);
            this.txt_Getraenkenummer.Name = "txt_Getraenkenummer";
            this.txt_Getraenkenummer.Size = new System.Drawing.Size(126, 20);
            this.txt_Getraenkenummer.TabIndex = 14;
            // 
            // btn_Verkaufen
            // 
            this.btn_Verkaufen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Verkaufen.Location = new System.Drawing.Point(737, 127);
            this.btn_Verkaufen.Name = "btn_Verkaufen";
            this.btn_Verkaufen.Size = new System.Drawing.Size(120, 50);
            this.btn_Verkaufen.TabIndex = 15;
            this.btn_Verkaufen.Text = "Verkaufen";
            this.btn_Verkaufen.UseVisualStyleBackColor = true;
            // 
            // Getraenkeuebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.btn_Verkaufen);
            this.Controls.Add(this.txt_Getraenkenummer);
            this.Controls.Add(this.lbl_Getraenkenummer);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_neuesGetraenk);
            this.Controls.Add(this.lbl_Getraenkeuebersicht);
            this.Name = "Getraenkeuebersicht";
            this.Text = "Getraenkeuebersicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Button btn_neuesGetraenk;
        private System.Windows.Forms.Label lbl_Getraenkeuebersicht;
        private System.Windows.Forms.Label lbl_Getraenkenummer;
        private System.Windows.Forms.TextBox txt_Getraenkenummer;
        private System.Windows.Forms.Button btn_Verkaufen;
    }
}