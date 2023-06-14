using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_UI.Forms
{
    public partial class FormStergereClient : Form
    {
        private const string folderPathClienti = "../../../";
        private const string fileNameClienti = "Clienti.txt";
        private string filePathClientiTxt = Path.Combine(folderPathClienti, fileNameClienti);

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

        public FormStergereClient()
        {
            InitializeComponent();
        }

        private void FormStergeClient_Load(object sender, EventArgs e)
        {
            BtnClear.Visible = false;
            BtnDa.Visible = false;
            BtnNu.Visible = false;
            BtnSterge.Visible = false;

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

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClienti());
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCodPersonal.Text = null;
            TxtNume.Text = null;
            TxtPrenume.Text = null;
            TxtSuma.Text = null;

            BtnClear.Visible = false;
            BtnDa.Visible = false;
            BtnNu.Visible = false;

            LblConfirmareText.Text = null;

            BtnSearch.Visible = true;

            LblClient.ForeColor = Color.Black;
            LblCodPersonal.ForeColor = Color.Black;
            LblText.Text = null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathClientiTxt);
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

                    BtnSearch.Visible = false;

                    BtnClear.Visible = true;
                    BtnSterge.Visible = true;

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

        private void TxtCodPersonal_TextChanged(object sender, EventArgs e)
        {
            TxtNume.Text = null;
            TxtPrenume.Text = null;
            TxtSuma.Text = null;

            BtnSearch.Visible = true;

            BtnClear.Visible = false;
            BtnNu.Visible = false;
            BtnDa.Visible = false;
            BtnSterge.Visible = false;

            LblConfirmareText.Text = null;
        }

        private void BtnSterge_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathClientiTxt);

            List<string> deleteLines = new List<string>();

            bool foundClient = false;

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCodPersonal.Text)
                {
                    foundClient = true;
                    continue;
                }

                deleteLines.Add(line);
            }

            if (foundClient)
            {
                BtnSterge.Visible = false;

                BtnNu.Visible = true;
                BtnDa.Visible = true;
                LblConfirmareText.Text = "Sunteți sigur?";
            }
        }

        private void BtnNu_Click(object sender, EventArgs e)
        {
            BtnDa.Visible = false;
            BtnNu.Visible = false;

            LblConfirmareText.Text = null;

            BtnSterge.Visible = true;
        }

        private void BtnDa_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathClientiTxt);

            List<string> deleteLines = new List<string>();

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCodPersonal.Text)
                    continue;

                deleteLines.Add(line);
            }

            File.WriteAllLines(filePathClientiTxt, deleteLines);

            LblText.Text = $"Clientul a fost șters din 'Clienti.txt' cu codul personal '{TxtCodPersonal.Text}'";

            BtnDa.Visible = false;
            BtnNu.Visible = false;
            BtnClear.Visible = false;
            BtnSterge.Visible = false;

            BtnSearch.Visible = true;

            LblConfirmareText.Text = null;
            TxtCodPersonal.Text = null;
            TxtNume.Text = null;
            TxtPrenume.Text = null;
            TxtSuma.Text = null;
        }

        private void LblText_Click(object sender, EventArgs e)
        {
            LblText.Text = null;
        }
    }
}
