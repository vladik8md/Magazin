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
    public partial class FormEditareClient : Form
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

        public FormEditareClient()
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

                    if (!string.IsNullOrEmpty(TxtNume.Text))
                    {
                        BtnEditNume.Visible = true;
                        BtnEditPrenume.Visible = true;
                        BtnEditSuma.Visible = true;
                        BtnClear.Visible = true;

                        BtnSearch.Visible = false;
                    }

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

            BtnEditNume.Visible = false;
            BtnEditPrenume.Visible = false;
            BtnEditSuma.Visible = false;
            BtnSaveNume.Visible = false;
            BtnSavePrenume.Visible = false;
            BtnSaveSuma.Visible = false;
            BtnClear.Visible = false;
            BtnCalc.Visible = false;

            BtnSearch.Visible = true;

            LblClient.ForeColor = Color.Black;
            LblCodPersonal.ForeColor = Color.Black;
            LblText.Text = null;
        }

        private void BtnEditNume_Click(object sender, EventArgs e)
        {
            TxtNume.ReadOnly = false;
            BtnEditNume.Visible = false;
            BtnEditPrenume.Visible= false;
            BtnEditSuma.Visible= false;

            BtnSaveNume.Visible = true;
        }

        private void BtnEditPrenume_Click(object sender, EventArgs e)
        {
            TxtPrenume.ReadOnly = false;
            BtnEditPrenume.Visible = false;
            BtnEditNume.Visible = false;
            BtnEditSuma.Visible = false;

            BtnSavePrenume.Visible = true;
        }

        private void BtnEditSuma_Click(object sender, EventArgs e)
        {
            TxtSuma.ReadOnly = false;
            BtnEditSuma.Visible = false;
            BtnEditNume.Visible = false;
            BtnEditPrenume.Visible = false;

            BtnSaveSuma.Visible = true;
            BtnCalc.Visible = true;
        }

        private void BtnSaveNume_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathClientiTxt);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCodPersonal.Text)
                {
                    values[1] = TxtNume.Text;

                    if (string.IsNullOrWhiteSpace(values[1]))
                    {
                        LblNume.ForeColor = Color.Red;
                        LblClient.ForeColor = Color.Red;
                        return;
                    }

                    LblNume.ForeColor = Color.Black;
                    LblClient.ForeColor = Color.Black;
                    LblText.Text = null;

                    lines[i] = string.Join(",", values);
                    break;
                }
            }

            File.WriteAllLines(filePathClientiTxt, lines);

            TxtNume.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(TxtNume.Text) || string.IsNullOrWhiteSpace(TxtPrenume.Text) || string.IsNullOrWhiteSpace(TxtSuma.Text))
                LblClient.ForeColor = Color.Red;

            BtnEditNume.Visible = true;
            BtnEditSuma.Visible = true;
            BtnEditPrenume.Visible = true;

            BtnSaveNume.Visible = false;
        }

        private void BtnSavePrenume_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathClientiTxt);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCodPersonal.Text)
                {
                    values[2] = TxtPrenume.Text;

                    if (string.IsNullOrWhiteSpace(values[2]))
                    {
                        LblPrenume.ForeColor = Color.Red;
                        LblClient.ForeColor = Color.Red;
                        return;
                    }

                    LblPrenume.ForeColor = Color.Black;
                    LblClient.ForeColor = Color.Black;
                    LblText.Text = null;

                    lines[i] = string.Join(",", values);
                    break;
                }
            }

            File.WriteAllLines(filePathClientiTxt, lines);

            TxtPrenume.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(TxtNume.Text) || string.IsNullOrWhiteSpace(TxtPrenume.Text) || string.IsNullOrWhiteSpace(TxtSuma.Text))
            {
                LblClient.ForeColor = Color.Red;
            }

            BtnEditPrenume.Visible = true;
            BtnEditSuma.Visible = true;
            BtnEditNume.Visible = true;

            BtnSavePrenume.Visible = false;
        }

        private void BtnSaveSuma_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathClientiTxt);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCodPersonal.Text)
                {
                    values[3] = TxtSuma.Text;

                    if (string.IsNullOrWhiteSpace(values[3]) || !double.TryParse(values[3], out double suma))
                    {
                        LblSuma.ForeColor = Color.Red;
                        LblClient.ForeColor = Color.Red;
                        return;
                    }

                    LblSuma.ForeColor = Color.Black;
                    LblClient.ForeColor = Color.Black;
                    LblText.Text = null;

                    lines[i] = string.Join(",", values);
                    break;
                }
            }

            File.WriteAllLines(filePathClientiTxt, lines);

            TxtSuma.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(TxtNume.Text) || string.IsNullOrWhiteSpace(TxtPrenume.Text) || string.IsNullOrWhiteSpace(TxtSuma.Text))
                LblClient.ForeColor = Color.Red;

            BtnEditPrenume.Visible = true;
            BtnEditSuma.Visible = true;
            BtnEditNume.Visible = true;

            BtnSaveSuma.Visible = false;
            BtnCalc.Visible = false;
        }

        private void FormEditareClient_Load(object sender, EventArgs e)
        {
            BtnEditNume.Visible = false;
            BtnEditPrenume.Visible = false;
            BtnEditSuma.Visible = false;
            BtnSaveNume.Visible = false;
            BtnSavePrenume.Visible = false;
            BtnSaveSuma.Visible = false;
            BtnClear.Visible = false;
            BtnCalc.Visible = false;

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
            BtnEditNume.Visible = false;
            BtnSaveNume.Visible = false;
            BtnSavePrenume.Visible = false;
            BtnSaveSuma.Visible = false;
            BtnEditPrenume.Visible = false;
            BtnEditSuma.Visible = false;
            BtnCalc.Visible = false;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
