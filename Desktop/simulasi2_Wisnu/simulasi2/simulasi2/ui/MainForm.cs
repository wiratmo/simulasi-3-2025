using simulasi2.ui.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace simulasi2.ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UCTableSeating uCTableSeating = new UCTableSeating();
            loadUC(uCTableSeating);
        }

        private void btnTableSeating_Click(object sender, EventArgs e)
        {
            UCTableSeating uCTableSeating = new UCTableSeating();
            loadUC(uCTableSeating);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            UCMenu uCMenu = new UCMenu();
            loadUC(uCMenu);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            UCHistory uCHistory = new UCHistory();
            loadUC(uCHistory);
        }

        private void loadUC(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }
    }
}
