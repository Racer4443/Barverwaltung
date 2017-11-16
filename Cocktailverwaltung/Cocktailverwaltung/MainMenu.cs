using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocktailverwaltung
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Buttons
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Hauptmenue_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Ausloggen_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Getraenkeuebersicht_Click(object sender, EventArgs e)
        {
            new Getraenkeuebersicht().Show();
        }

        private void btn_Benutzerverwaltung_Click(object sender, EventArgs e)
        {
            new Benutzerverwaltung().Show();
        }

        private void btn_Finanzen_Click(object sender, EventArgs e)
        {
            new Finanzen().Show();
        }

        private void btn_Lagerverwaltung_Click(object sender, EventArgs e)
        {
            new Lagerverwaltung().Show();
        }

        private void btn_Logbuch_Click(object sender, EventArgs e)
        {
            new Logbuch().Show();
        }

        private void btn_Templateverwaltung_Click(object sender, EventArgs e)
        {
            new Templateverwaltung().Show();
        }
        #endregion
    }
}
