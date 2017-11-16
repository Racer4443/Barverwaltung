using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cocktailverwaltung
{
    public partial class Neuer_Benutzer : Form
    {
        public Neuer_Benutzer()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_Vorname.Text == "" || txt_Nachname.Text == "" || txt_Benutzername.Text == "" || txt_Passwort.Text == "" || txt_TemplateNr.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
            else
            {
                MySqlCommand benutzerdaten_einfuegen = new MySqlCommand("INSERT INTO benutzerverwaltung (vorname, nachname, benutzername, passwort, template_nr) VALUES '"
                    + txt_Vorname.Text + "', '" + txt_Nachname.Text + "', '" + txt_Benutzername.Text + "', '" + txt_Passwort.Text + "', '" + txt_TemplateNr + "';");
                MessageBox.Show("Benutzer erstellt!");
                this.Close();
                new Benutzerverwaltung().Show();
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
            new Benutzerverwaltung().Show();
        }
    }
}
