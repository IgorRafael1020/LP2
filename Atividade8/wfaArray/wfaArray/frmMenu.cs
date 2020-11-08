using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaArray
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmiExercicio1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio1>().First().Focus();
            }
            else
            {
                frmExercicio1 FrmExercicio1 = new frmExercicio1();
                FrmExercicio1.MdiParent = this;
                FrmExercicio1.WindowState = FormWindowState.Maximized;
                FrmExercicio1.Show();
            }
        }

        private void tsmiExercicio2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio2>().First().Focus();
            }
            else
            {
                frmExercicio2 FrmExercicio2 = new frmExercicio2();
                FrmExercicio2.MdiParent = this;
                FrmExercicio2.WindowState = FormWindowState.Maximized;
                FrmExercicio2.Show();
            }
        }

        private void tsmiExercicio3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio3>().First().Focus();
            }
            else
            {
                frmExercicio3 FrmExercicio3 = new frmExercicio3();
                FrmExercicio3.MdiParent = this;
                FrmExercicio3.WindowState = FormWindowState.Maximized;
                FrmExercicio3.Show();
            }
        }

        private void tsmiExercicio4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio4>().First().Focus();
            }
            else
            {
                frmExercicio4 FrmExercicio4 = new frmExercicio4();
                FrmExercicio4.MdiParent = this;
                FrmExercicio4.WindowState = FormWindowState.Maximized;
                FrmExercicio4.Show();
            }
        }

        private void tsmiExercicio5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio5>().First().Focus();
            }
            else
            {
                frmExercicio5 FrmExercicio5 = new frmExercicio5();
                FrmExercicio5.MdiParent = this;
                FrmExercicio5.WindowState = FormWindowState.Maximized;
                FrmExercicio5.Show();
            }
        }

        private void tsmiExercicio6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio6>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio6>().First().Focus();
            }
            else
            {
                frmExercicio6 FrmExercicio6 = new frmExercicio6();
                FrmExercicio6.MdiParent = this;
                FrmExercicio6.WindowState = FormWindowState.Maximized;
                FrmExercicio6.Show();
            }
        }

        private void tsmiExercicio7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio7>().Count() > 0)
            {
                Application.OpenForms.OfType<frmExercicio7>().First().Focus();
            }
            else
            {
                frmExercicio7 FrmExercicio7 = new frmExercicio7();
                FrmExercicio7.MdiParent = this;
                FrmExercicio7.WindowState = FormWindowState.Maximized;
                FrmExercicio7.Show();
            }
        }
    }
}
