using System;
using Magazin;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Magazin_UI.Forms
{
    public partial class FormCautareClient : Form
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

        private void FormCautareClient_Load(object sender, EventArgs e)
        {
            BtnClear.Visible = false;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyDown += (s, ea) =>
                    {
                        if (ea.KeyCode != Keys.Enter) return;
                        ea.SuppressKeyPress = true;
                        SelectNextControl(ActiveControl, true, true, true, true);
                    };
                }
            }
        }

        public FormCautareClient()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClienti());
        }

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            string grandParentDirectory = Directory.GetParent(parentDirectory)?.FullName;
            string greatGrandParentDirectory = Directory.GetParent(grandParentDirectory)?.FullName;

            if (greatGrandParentDirectory != null)
            {
                string targetFolder = Path.GetFullPath(greatGrandParentDirectory);
                string filePath = Path.Combine(targetFolder, "Clienti.txt");
                Process.Start(filePath);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Client.FilePath);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCodPersonal.Text)
                {
                    string nume = values[1];
                    string prenume = values[2];
                    string suma = values[3];

                    TxtNume.Text = nume;
                    TxtPrenume.Text = prenume;
                    TxtSuma.Text = suma;

                    BtnClear.Visible = true;

                    BtnSearch.Visible = false;

                    LblClient.ForeColor = Color.Black;
                    LblCodPersonal.ForeColor = Color.Black;
                    LblText.Text = null;

                    return;
                }
            }

            if (string.IsNullOrEmpty(TxtNume.Text))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblText.Text = "Introduceți codul personal al clientului deja existent.";
                return;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCodPersonal.Text = null;
            TxtNume.Text = null;
            TxtPrenume.Text = null;
            TxtSuma.Text = null;
            
            BtnClear.Visible = false;
            BtnSearch.Visible = true;

            LblClient.ForeColor = Color.Black;
            LblCodPersonal.ForeColor = Color.Black;
            LblText.Text = null;
        }

        private void LblText_Click(object sender, EventArgs e)
        {
            LblText.Text = null;
        }

        private void TxtCodPersonal_TextChanged(object sender, EventArgs e)
        {
            TxtNume.Text = null;
            TxtPrenume.Text = null;
            TxtSuma.Text = null;

            BtnSearch.Visible = true;

            BtnClear.Visible = false;
        }
    }
}
