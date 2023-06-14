using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_UI.Forms
{
    public partial class FormClienti : Form
    {
        private Form activeForm;

        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public FormClienti()
        {
            InitializeComponent();
        }

        private void FormClienti_Load(object sender, EventArgs e) { }

        private void BtnAdaugare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdaugareClient());
        }

        private void BtnAfisare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAfisareClienti());
        }

        private void BtnEditare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEditareClient());
        }

        private void BtnCautare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCautareClient());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void BtnStergere_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStergereClient());
        }
    }
}
