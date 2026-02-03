using simulasi.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulasi
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UCSeating());
        }

        private void LoadUserControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCMenu());
            BtnSeating.BackColor = Color.DarkGray;
            btnMenu.BackColor = Color.RoyalBlue;
            btnHistory.BackColor = Color.DarkGray;

         
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCHistory());
            btnHistory.BackColor = Color.RoyalBlue;
            BtnSeating.BackColor = Color.DarkGray;
            btnMenu.BackColor = Color.DarkGray;
        }

        private void BtnSeating_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCSeating());
            BtnSeating.BackColor = Color.RoyalBlue;
            btnMenu.BackColor = Color.DarkGray;
            btnHistory.BackColor = Color.DarkGray;


        }
    }
}
