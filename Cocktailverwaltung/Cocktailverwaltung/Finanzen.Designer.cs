namespace Cocktailverwaltung
{
    partial class Finanzen
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
            this.lbl_Finanzen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Zurueck.Location = new System.Drawing.Point(742, 9);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(120, 50);
            this.btn_Zurueck.TabIndex = 15;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // lbl_Finanzen
            // 
            this.lbl_Finanzen.AutoSize = true;
            this.lbl_Finanzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Finanzen.Location = new System.Drawing.Point(12, 9);
            this.lbl_Finanzen.Name = "lbl_Finanzen";
            this.lbl_Finanzen.Size = new System.Drawing.Size(181, 42);
            this.lbl_Finanzen.TabIndex = 14;
            this.lbl_Finanzen.Text = "Finanzen";
            // 
            // Finanzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.lbl_Finanzen);
            this.Name = "Finanzen";
            this.Text = "Finanzen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Label lbl_Finanzen;
    }
}