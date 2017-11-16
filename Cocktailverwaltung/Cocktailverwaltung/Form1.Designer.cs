namespace Cocktailverwaltung
{
    partial class frm_Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txt_Benutzername = new System.Windows.Forms.TextBox();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OK = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Benutzername.Location = new System.Drawing.Point(9, 91);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(170, 25);
            this.lbl_Benutzername.TabIndex = 0;
            this.lbl_Benutzername.Text = "Benutzername:";
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.Location = new System.Drawing.Point(64, 128);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(115, 25);
            this.lbl_Passwort.TabIndex = 1;
            this.lbl_Passwort.Text = "Passwort:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(178, 35);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(115, 42);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login";
            // 
            // txt_Benutzername
            // 
            this.txt_Benutzername.Location = new System.Drawing.Point(185, 96);
            this.txt_Benutzername.Name = "txt_Benutzername";
            this.txt_Benutzername.Size = new System.Drawing.Size(136, 20);
            this.txt_Benutzername.TabIndex = 4;
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(185, 133);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(136, 20);
            this.txt_Passwort.TabIndex = 5;
            this.txt_Passwort.TextChanged += new System.EventHandler(this.txt_Passwort_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(185, 173);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(136, 68);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 260);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.txt_Benutzername);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_Benutzername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Login";
            this.Text = "Barverwaltung";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txt_Benutzername;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.Button btn_OK;
    }
}

