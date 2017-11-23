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
    public partial class Benutzerverwaltung : Form
    {
        public Benutzerverwaltung()
        {
            InitializeComponent();
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }

        private void btn_neuerBenutzer_Click(object sender, EventArgs e) 
        {
            this.Close();
            new Neuer_Benutzer().Show();
        }

        private void Benutzerverwaltung_Load(object sender, EventArgs e)
        {

        }
    }
}
