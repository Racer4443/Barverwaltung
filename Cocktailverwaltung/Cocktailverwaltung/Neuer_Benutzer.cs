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
            MySqlConnection con = new MySqlConnection("SERVER=eduweb.kb.local;" + "DATABASE=team02;" + "UID=team02;" + "PASSWORD=T3amO2");
            con.Open();

            if (txt_Vorname.Text == "" || txt_Nachname.Text == "" || txt_Benutzername.Text == "" || txt_Passwort.Text == "" || txt_TemplateNr.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
            else
            {
                MySqlCommand benutzerdaten_einfuegen = new MySqlCommand("INSERT INTO benutzerverwaltung (vorname, nachname, benutzername, passwort, template_nr) VALUES ('"
                    + txt_Vorname.Text + "', '" + txt_Nachname.Text + "', '" + txt_Benutzername.Text + "', '" + txt_Passwort.Text + "', '" + txt_TemplateNr + "');", con);
                try
                {
                    var reader = benutzerdaten_einfuegen.ExecuteReader();
                    while (reader.Read())
                    {
                        benutzerdaten_einfuegen.ExecuteNonQuery();
                    }
                    reader.Close();
                    MessageBox.Show("Benutzer erstellt!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Fehler. Benutzer nichzt erstellt.");
                }
                this.Close();
                new Benutzerverwaltung().Show();
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
            new Benutzerverwaltung().Show();
        }

        private void Neuer_Benutzer_Load(object sender, EventArgs e)
        {

        }
    }
}
