namespace Cocktailverwaltung
{
    partial class Lagerverwaltung
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
            this.lbl_Lagerverwaltung = new System.Windows.Forms.Label();
            this.btn_Aufstocken = new System.Windows.Forms.Button();
            this.btn_neuesProdukt = new System.Windows.Forms.Button();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Lagerverwaltung
            // 
            this.lbl_Lagerverwaltung.AutoSize = true;
            this.lbl_Lagerverwaltung.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Lagerverwaltung.Location = new System.Drawing.Point(11, 12);
            this.lbl_Lagerverwaltung.Name = "lbl_Lagerverwaltung";
            this.lbl_Lagerverwaltung.Size = new System.Drawing.Size(310, 42);
            this.lbl_Lagerverwaltung.TabIndex = 0;
            this.lbl_Lagerverwaltung.Text = "Lagerverwaltung";
            // 
            // btn_Aufstocken
            // 
            this.btn_Aufstocken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Aufstocken.Location = new System.Drawing.Point(316, 12);
            this.btn_Aufstocken.Name = "btn_Aufstocken";
            this.btn_Aufstocken.Size = new System.Drawing.Size(120, 50);
            this.btn_Aufstocken.TabIndex = 1;
            this.btn_Aufstocken.Text = "Aufstocken";
            this.btn_Aufstocken.UseVisualStyleBackColor = true;
            // 
            // btn_neuesProdukt
            // 
            this.btn_neuesProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_neuesProdukt.Location = new System.Drawing.Point(442, 12);
            this.btn_neuesProdukt.Name = "btn_neuesProdukt";
            this.btn_neuesProdukt.Size = new System.Drawing.Size(120, 50);
            this.btn_neuesProdukt.TabIndex = 2;
            this.btn_neuesProdukt.Text = "Neues Produkt";
            this.btn_neuesProdukt.UseVisualStyleBackColor = true;
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Suchen.Location = new System.Drawing.Point(568, 12);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(120, 50);
            this.btn_Suchen.TabIndex = 3;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = true;
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Zurueck.Location = new System.Drawing.Point(742, 12);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(120, 50);
            this.btn_Zurueck.TabIndex = 4;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // Lagerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.btn_neuesProdukt);
            this.Controls.Add(this.btn_Aufstocken);
            this.Controls.Add(this.lbl_Lagerverwaltung);
            this.Name = "Lagerverwaltung";
            this.Text = "Lagerverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lagerverwaltung;
        private System.Windows.Forms.Button btn_Aufstocken;
        private System.Windows.Forms.Button btn_neuesProdukt;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.Button btn_Zurueck;
    }
}