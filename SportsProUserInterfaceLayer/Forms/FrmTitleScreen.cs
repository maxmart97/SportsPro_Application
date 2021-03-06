﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer.Forms
{
    public partial class FrmTitleScreen : Form
    {
        public FrmTitleScreen()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin")
            {
                if (tbPassword.Text == "password")
                {
                    FrmMain myFrmMain = new FrmMain();

                    myFrmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password is incorrect.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username is incorrect.", "Incorrect Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
