using lks3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks3.views
{
    public partial class TableSeatingForm : Form
    {
        public TableSeatingForm()
        {
            InitializeComponent();
        }

        private void TableSeatingForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            Meja.A1Dipencet = true;
            Meja.C1Dipencet = false;
            Meja.A2Dipencet = false;
            Meja.B1Dipencet = false;
            Meja.B2Dipencet = false;
            Meja.A3Dipencet = false;
            Meja.C2Dipencet = false;
            Meja.A4Dipencet = false;
            if (Meja.A1Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (Meja.C1Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (Meja.A2Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (Meja.B1Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (Meja.B2Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (Meja.A3Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (Meja.C2Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            if (Meja.A4Ditempati == false)
            {
                new AssignTableForm().Show();
            }
            else
            {
                new TableSeatingDetail().Show();
            }
        }

        private void btnTableSeating_Click(object sender, EventArgs e)
        {
            new TableSeatingForm().Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new HistoryForm().Show();
            this.Hide();
        }
    }
}
