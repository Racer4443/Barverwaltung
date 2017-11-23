namespace Cocktailverwaltung
{
    partial class Neuer_Benutzer
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
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.lbl_TemplateNr = new System.Windows.Forms.Label();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.txt_Benutzername = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.txt_TemplateNr = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Location = new System.Drawing.Point(54, 39);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Vorname.TabIndex = 0;
            this.lbl_Vorname.Text = "Vorname:";
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Location = new System.Drawing.Point(54, 69);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(62, 13);
            this.lbl_Nachname.TabIndex = 1;
            this.lbl_Nachname.Text = "Nachname:";
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.Location = new System.Drawing.Point(54, 97);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(78, 13);
            this.lbl_Benutzername.TabIndex = 2;
            this.lbl_Benutzername.Text = "Benutzername:";
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Location = new System.Drawing.Point(54, 127);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(53, 13);
            this.lbl_Passwort.TabIndex = 3;
            this.lbl_Passwort.Text = "Passwort:";
            // 
            // lbl_TemplateNr
            // 
            this.lbl_TemplateNr.AutoSize = true;
            this.lbl_TemplateNr.Location = new System.Drawing.Point(54, 154);
            this.lbl_TemplateNr.Name = "lbl_TemplateNr";
            this.lbl_TemplateNr.Size = new System.Drawing.Size(71, 13);
            this.lbl_TemplateNr.TabIndex = 4;
            this.lbl_TemplateNr.Text = "Template Nr.:";
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(148, 36);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(100, 20);
            this.txt_Vorname.TabIndex = 5;
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(148, 69);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nachname.TabIndex = 6;
            // 
            // txt_Benutzername
            // 
            this.txt_Benutzername.Location = new System.Drawing.Point(148, 95);
            this.txt_Benutzername.Name = "txt_Benutzername";
            this.txt_Benutzername.Size = new System.Drawing.Size(100, 20);
            this.txt_Benutzername.TabIndex = 7;
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(148, 124);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(100, 20);
            this.txt_Passwort.TabIndex = 8;
            // 
            // txt_TemplateNr
            // 
            this.txt_TemplateNr.Location = new System.Drawing.Point(148, 151);
            this.txt_TemplateNr.Name = "txt_TemplateNr";
            this.txt_TemplateNr.Size = new System.Drawing.Size(100, 20);
            this.txt_TemplateNr.TabIndex = 9;
            this.txt_TemplateNr.Text = "0";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(57, 209);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(148, 209);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.btn_Abbrechen.TabIndex = 11;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // Neuer_Benutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_TemplateNr);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.txt_Benutzername);
            this.Controls.Add(this.txt_Nachname);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.lbl_TemplateNr);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_Benutzername);
            this.Controls.Add(this.lbl_Nachname);
            this.Controls.Add(this.lbl_Vorname);
            this.Name = "Neuer_Benutzer";
            this.Text = "Neuer_Benutzer";
            this.Load += new System.EventHandler(this.Neuer_Benutzer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_TemplateNr;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.TextBox txt_Benutzername;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.TextBox txt_TemplateNr;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Abbrechen;
    }
}