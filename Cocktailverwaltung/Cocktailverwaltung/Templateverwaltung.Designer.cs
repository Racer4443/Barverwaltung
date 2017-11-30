namespace Cocktailverwaltung
{
    partial class Templateverwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Templateverwaltung));
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.lbl_Templateverwaltung = new System.Windows.Forms.Label();
            this.btn_neuesTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Zurueck
            // 
            resources.ApplyResources(this.btn_Zurueck, "btn_Zurueck");
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            this.btn_Zurueck.Click += new System.EventHandler(this.btn_Zurueck_Click);
            // 
            // lbl_Templateverwaltung
            // 
            resources.ApplyResources(this.lbl_Templateverwaltung, "lbl_Templateverwaltung");
            this.lbl_Templateverwaltung.Name = "lbl_Templateverwaltung";
            // 
            // btn_neuesTemplate
            // 
            resources.ApplyResources(this.btn_neuesTemplate, "btn_neuesTemplate");
            this.btn_neuesTemplate.Name = "btn_neuesTemplate";
            this.btn_neuesTemplate.UseVisualStyleBackColor = true;
            // 
            // Templateverwaltung
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_neuesTemplate);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.lbl_Templateverwaltung);
            this.Name = "Templateverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Label lbl_Templateverwaltung;
        private System.Windows.Forms.Button btn_neuesTemplate;
    }
}