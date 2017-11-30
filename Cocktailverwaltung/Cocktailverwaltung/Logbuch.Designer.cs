namespace Cocktailverwaltung
{
    partial class Logbuch
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
            this.lbl_Logbuch = new System.Windows.Forms.Label();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Logbuch
            // 
            this.lbl_Logbuch.AutoSize = true;
            this.lbl_Logbuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Logbuch.Location = new System.Drawing.Point(12, 9);
            this.lbl_Logbuch.Name = "lbl_Logbuch";
            this.lbl_Logbuch.Size = new System.Drawing.Size(170, 42);
            this.lbl_Logbuch.TabIndex = 11;
            this.lbl_Logbuch.Text = "Logbuch";
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Zurueck.Location = new System.Drawing.Point(742, 9);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(120, 50);
            this.btn_Zurueck.TabIndex = 13;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // Logbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.lbl_Logbuch);
            this.Name = "Logbuch";
            this.Text = "Logbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Logbuch;
        private System.Windows.Forms.Button btn_Zurueck;
    }
}