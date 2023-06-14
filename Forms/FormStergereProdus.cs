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
    public partial class FormStergereProdus : Form
    {
        private const string folderPathProduse = "../../../";
        private const string fileNameProduse = "Produse.txt";
        private string filePathProduseTxt = Path.Combine(folderPathProduse, fileNameProduse);

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

        public FormStergereProdus()
        {
            InitializeComponent();
        }

        private void FormStergeProdus_Load(object sender, EventArgs e)
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathProduseTxt);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCod.Text)
                {
                    string categorie = values[1];
                    string denumire = values[2];
                    string pret = values[3];

                    TxtCategorie.Text = categorie;
                    TxtDenumire.Text = denumire;
                    TxtPret.Text = pret;

                    BtnSearch.Visible = false;

                    BtnClear.Visible = true;
                    BtnSterge.Visible = true;

                    LblProdus.ForeColor = Color.Black;
                    LblCod.ForeColor = Color.Black;
                    LblText.Text = null;

                    return;
                }
            }

            if (string.IsNullOrEmpty(TxtCategorie.Text))
            {
                LblProdus.ForeColor = Color.Red;
                LblCod.ForeColor = Color.Red;
                LblText.Text = "Introduceți codul produsului deja existent.";
                return;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCod.Text = null;
            TxtCategorie.Text = null;
            TxtDenumire.Text = null;
            TxtPret.Text = null;

            BtnClear.Visible = false;
            BtnDa.Visible = false;
            BtnNu.Visible = false;

            LblConfirmareText.Text = null;

            BtnSearch.Visible = true;

            LblProdus.ForeColor = Color.Black;
            LblCod.ForeColor = Color.Black;
            LblText.Text = null;
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
                string filePath = Path.Combine(targetFolder, "Produse.txt");
                Process.Start(filePath);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduse());
        }

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSterge_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathProduseTxt);

            List<string> deleteLines = new List<string>();

            bool foundProduct = false;

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCod.Text)
                {
                    foundProduct = true;
                    continue;
                }

                deleteLines.Add(line);
            }

            if (foundProduct)
            {
                BtnSterge.Visible = false;

                BtnNu.Visible = true;
                BtnDa.Visible = true;
                LblConfirmareText.Text = "Sunteți sigur?";
            }

        }

        private void LblText_Click(object sender, EventArgs e)
        {
            LblText.Text = null;
        }

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {
            TxtCategorie.Text = null;
            TxtDenumire.Text = null;
            TxtPret.Text = null;

            BtnSearch.Visible = true;

            BtnClear.Visible = false;
            BtnNu.Visible = false;
            BtnDa.Visible = false;
            BtnSterge.Visible = false;

            LblConfirmareText.Text = null;
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
            string[] lines = File.ReadAllLines(filePathProduseTxt);

            List<string> deleteLines = new List<string>();

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCod.Text)
                    continue;

                deleteLines.Add(line);
            }

            File.WriteAllLines(filePathProduseTxt, deleteLines);

            LblText.Text = $"Produsul a fost șters din 'Produse.txt' cu codul '{TxtCod.Text}'";

            BtnDa.Visible = false;
            BtnNu.Visible = false;
            BtnClear.Visible = false;
            BtnSterge.Visible = false;

            BtnSearch.Visible = true;

            LblConfirmareText.Text = null;
            TxtCod.Text = null;
            TxtCategorie.Text = null;
            TxtDenumire.Text = null;
            TxtPret.Text = null;
        }
    }
}
