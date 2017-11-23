namespace Cocktailverwaltung
{
    partial class Benutzerverwaltung
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
            this.btn_neuerBenutzer = new System.Windows.Forms.Button();
            this.lbl_Benutzerverwaltung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Zurueck.Location = new System.Drawing.Point(743, 9);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(120, 50);
            this.btn_Zurueck.TabIndex = 9;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // btn_neuerBenutzer
            // 
            this.btn_neuerBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_neuerBenutzer.Location = new System.Drawing.Point(385, 9);
            this.btn_neuerBenutzer.Name = "btn_neuerBenutzer";
            this.btn_neuerBenutzer.Size = new System.Drawing.Size(120, 50);
            this.btn_neuerBenutzer.TabIndex = 7;
            this.btn_neuerBenutzer.Text = "Neuer Benutzer";
            this.btn_neuerBenutzer.UseVisualStyleBackColor = true;
            this.btn_neuerBenutzer.Click += new System.EventHandler(this.btn_neuerBenutzer_Click);
            // 
            // lbl_Benutzerverwaltung
            // 
            this.lbl_Benutzerverwaltung.AutoSize = true;
            this.lbl_Benutzerverwaltung.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Benutzerverwaltung.Location = new System.Drawing.Point(12, 9);
            this.lbl_Benutzerverwaltung.Name = "lbl_Benutzerverwaltung";
            this.lbl_Benutzerverwaltung.Size = new System.Drawing.Size(367, 42);
            this.lbl_Benutzerverwaltung.TabIndex = 5;
            this.lbl_Benutzerverwaltung.Text = "Benutzerverwaltung";
            // 
            // Benutzerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_neuerBenutzer);
            this.Controls.Add(this.lbl_Benutzerverwaltung);
            this.Name = "Benutzerverwaltung";
            this.Text = "Benutzerverwaltung";
            this.Load += new System.EventHandler(this.Benutzerverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Button btn_neuerBenutzer;
        private System.Windows.Forms.Label lbl_Benutzerverwaltung;
    }
}