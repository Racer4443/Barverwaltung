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
    public partial class Benutzerloeschen : Form
    {
        public Benutzerloeschen()
        {
            InitializeComponent();
        }

        private void Benutzerloeschen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Loeschen_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=eduweb.kb.local;" + "DATABASE=team02;" + "UID=team02;" + "PASSWORD=T3amO2");
            con.Open();

            if (txt_Benutzername.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Benutzername.Text == Globals.benutzername)
            {
                MessageBox.Show("Sie können nicht den Benutzer löschen, mit dem Sie gerade angemeldet sind.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlCommand benutzer_loeschen = new MySqlCommand("DELETE FROM benutzerverwaltung WHERE benutzername = '" + txt_Benutzername.Text + "';", con);
                try
                {
                    var reader = benutzer_loeschen.ExecuteReader();
                    while (reader.Read())
                    {
                        benutzer_loeschen.ExecuteNonQuery();
                    }
                    reader.Close();
                    MessageBox.Show("Benutzer '" + txt_Benutzername.Text + "' gelöscht!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Fehler. Prüfen Sie den Benutzernamen und versuchen Sie erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
                new Benutzerverwaltung().Show();
                con.Close();
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
            new Benutzerverwaltung().Show();
        }
    }
}
