﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class AdminReservation : MetroFramework.Forms.MetroForm
    {

        

        public AdminReservation()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AdminDashboardcs ad = new AdminDashboardcs();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }
    }
}
