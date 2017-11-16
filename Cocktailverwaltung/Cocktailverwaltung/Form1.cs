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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=eduweb.kb.local;" + "DATABASE=team02;" + "UID=team02;" + "PASSWORD=T3amO2"); // connecting to database
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM benutzerverwaltung WHERE benutzername='" + txt_Benutzername.Text + "' AND passwort='" + txt_Passwort.Text + "'", con);
            //search DB for User
            DataTable dt = new DataTable();
            sda.Fill(dt); //datatable is filled with values from sda

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new MainMenu().Show();
            }
            else
                MessageBox.Show("Diesen Nutzer gibt es nicht.");

        }

        private void txt_Passwort_TextChanged(object sender, EventArgs e)
        {

            txt_Passwort.PasswordChar = '*';
        }
        /*public static string Benutzername(txt_Benutzername)
        {
            string benutzername = txt_Benutzername.Text;
            return benutzername;
        }*/
    }
}
