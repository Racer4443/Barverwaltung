﻿using System;
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
    public partial class Templateverwaltung : Form
    {
        public Templateverwaltung()
        {
            InitializeComponent();
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }

        private void Templateverwaltung_Load(object sender, EventArgs e)
        {

        }
    }
}
