using Magazin;
using Magazin_UI.Forms;
using System;
using System.Windows.Forms;

namespace Magazin_UI
{
    public partial class FormProduse : Form
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

        public FormProduse()
        {
            InitializeComponent();
        }

        private void FormProduse_Load(object sender, EventArgs e)
        {
            Produs.CheckCategorii();
        }

        private void BtnAdaugare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdaugareProdus());
        }

        private void BtnAfisare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAfisareProduse());
        }

        private void BtnCautare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCautareProdus());
        }

        private void BtnEditare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEditareProdus());
        }

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStergere_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStergereProdus());
        }
    }
}
