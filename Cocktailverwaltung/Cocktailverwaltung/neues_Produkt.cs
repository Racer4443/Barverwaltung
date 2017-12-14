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
    public partial class neues_Produkt : Form
    {
        public neues_Produkt()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
            new Lagerverwaltung().Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=eduweb.kb.local;" + "DATABASE=team02;" + "UID=team02;" + "PASSWORD=T3amO2");
            con.Open();

            if (txt_Artikelbezeichnung.Text == "" || txt_Einkaufspreis.Text == "" || txt_Lieferant.Text == "" || cmb_Alkoholisch.Text == "" || cmb_Zubehoer.Text == ""
                || txt_Menge_in_Litern.Text == "" || txt_Stueckzahl.Text == "" || txt_Hinzugefuegt_von.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
            else
            {
                MySqlCommand produktdaten_einfuegen = new MySqlCommand("INSERT INTO lagerverwaltung (artikelbezeichnung, ek_preis, lieferant, alkoholisch, zubehoer, menge_in_liter, stueckzahl, hinzugefuegt_von) VALUES ('"
                    + txt_Artikelbezeichnung.Text + "', '" + txt_Einkaufspreis.Text + "', '" + txt_Lieferant.Text + "', '" + cmb_Alkoholisch.Text + "', " + cmb_Zubehoer.Text + "', " + txt_Menge_in_Litern.Text + "', " + txt_Stueckzahl + "', " + txt_Hinzugefuegt_von + ");", con);
                try
                {
                    var reader = produktdaten_einfuegen.ExecuteReader();
                    while (reader.Read())
                    {
                        produktdaten_einfuegen.ExecuteNonQuery();
                    }
                    reader.Close();
                    MessageBox.Show("Produkt angelegt.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Fehler. Produkt nicht angelegt.");
                }
                Close();
                con.Close();
                new Lagerverwaltung().Show();
            }
        }

        private void neues_Produkt_Load(object sender, EventArgs e)
        {

        }
    }
}
