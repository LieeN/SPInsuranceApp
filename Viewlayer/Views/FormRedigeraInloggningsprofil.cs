﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewlayer.Views
{
    public partial class FormRedigeraInloggningsprofil : Form
    {
        public FormRedigeraInloggningsprofil()
        {
            InitializeComponent();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
