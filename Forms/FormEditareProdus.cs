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
    public partial class FormEditareProdus : Form
    {
        private const string folderPath = "../../../";
        private const string fileNameCategorii = "Categorii.txt";
        private const string fileNameProduse = "Produse.txt";

        private string filePathCategoriiTxt;
        private string filePathProduseTxt;

        public enum FilePathOption
        {
            Categorii,
            Produse
        }

        private string GetFilePath(FilePathOption option)
        {
            string fileName;
            switch (option)
            {
                case FilePathOption.Categorii:
                    fileName = fileNameCategorii;
                    break;
                case FilePathOption.Produse:
                    fileName = fileNameProduse;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(option), option, "Aceasta cale nu exista.");
            }

            return Path.Combine(folderPath, fileName);
        }

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

        public FormEditareProdus()
        {
            filePathCategoriiTxt = GetFilePath(FilePathOption.Categorii);
            filePathProduseTxt = GetFilePath(FilePathOption.Produse);
            InitializeComponent();
        }

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduse());
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                    if (!string.IsNullOrEmpty(TxtCategorie.Text))
                    {
                        BtnEditCategorie.Visible = true;
                        BtnEditDenumire.Visible = true;
                        BtnEditPret.Visible = true;
                        BtnClear.Visible = true;

                        BtnSearch.Visible = false;
                    }

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

            BtnEditCategorie.Visible = false;
            BtnEditDenumire.Visible = false;
            BtnEditPret.Visible = false;
            BtnSaveCategorie.Visible = false;
            BtnSaveDenumire.Visible = false;
            BtnSavePret.Visible = false;
            BtnClear.Visible = false;
            BtnCalc.Visible = false;

            BtnSearch.Visible = true;

            LblProdus.ForeColor = Color.Black;
            LblCod.ForeColor = Color.Black;
            LblText.Text = null;
        }

        private void BtnEditCategorie_Click(object sender, EventArgs e)
        {
            TxtCategorie.ReadOnly = false;
            BtnEditCategorie.Visible = false;
            BtnEditDenumire.Visible = false;
            BtnEditPret.Visible = false;

            BtnSaveCategorie.Visible = true;
        }

        private void BtnEditDenumire_Click(object sender, EventArgs e)
        {
            TxtDenumire.ReadOnly = false;
            BtnEditDenumire.Visible = false;
            BtnEditCategorie.Visible = false;
            BtnEditPret.Visible = false;

            BtnSaveDenumire.Visible = true;
        }

        private void BtnEditPret_Click(object sender, EventArgs e)
        {
            TxtPret.ReadOnly = false;
            BtnEditPret.Visible = false;
            BtnEditDenumire.Visible = false;
            BtnEditCategorie.Visible = false;

            BtnSavePret.Visible = true;
            BtnCalc.Visible = true;
        }

        private void BtnSaveCategorie_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathProduseTxt);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCod.Text)
                {
                    values[1] = TxtCategorie.Text;

                    if (string.IsNullOrWhiteSpace(values[1]))
                    {
                        LblCategorie.ForeColor = Color.Red;
                        LblProdus.ForeColor = Color.Red;
                        return;
                    }

                    LblCategorie.ForeColor = Color.Black;
                    LblProdus.ForeColor = Color.Black;
                    LblText.Text = null;

                    lines[i] = string.Join(",", values);
                    break;
                }
            }

            File.WriteAllLines(filePathProduseTxt, lines);

            string[] categorii = File.ReadAllLines(filePathCategoriiTxt);
            string newCategorie = TxtCategorie.Text;

            bool categorieExists = categorii.Any(categorie => categorie.Trim() == newCategorie);
            if (!categorieExists)
            {
                using (StreamWriter sw = File.AppendText(filePathCategoriiTxt))
                {
                    sw.WriteLine(newCategorie);
                    LblText.Text = $"Categoria '{newCategorie}' a fost adăugată în fișierul 'Categorii.txt'.";
                }
            }

            TxtCategorie.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(TxtCategorie.Text) || string.IsNullOrWhiteSpace(TxtDenumire.Text) || string.IsNullOrWhiteSpace(TxtPret.Text))
                LblProdus.ForeColor = Color.Red;

            BtnEditCategorie.Visible = true;
            BtnEditPret.Visible = true;
            BtnEditDenumire.Visible = true;

            BtnSaveCategorie.Visible = false;
        }


        private void BtnSaveDenumire_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathProduseTxt);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCod.Text)
                {
                    values[2] = TxtDenumire.Text;

                    if (string.IsNullOrWhiteSpace(values[2]))
                    {
                        LblDenumire.ForeColor = Color.Red;
                        LblProdus.ForeColor = Color.Red;
                        return;
                    }

                    LblDenumire.ForeColor = Color.Black;
                    LblProdus.ForeColor = Color.Black;
                    LblText.Text = null;

                    lines[i] = string.Join(",", values);
                    break;
                }
            }

            File.WriteAllLines(filePathProduseTxt, lines);

            TxtDenumire.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(TxtCategorie.Text) || string.IsNullOrWhiteSpace(TxtDenumire.Text) || string.IsNullOrWhiteSpace(TxtPret.Text))
            {
                LblProdus.ForeColor = Color.Red;
            }

            BtnEditDenumire.Visible = true;
            BtnEditPret.Visible = true;
            BtnEditCategorie.Visible = true;

            BtnSaveDenumire.Visible = false;
        }

        private void BtnSavePret_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePathProduseTxt);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length == 4 && values[0] == TxtCod.Text)
                {
                    values[3] = TxtPret.Text;

                    if (string.IsNullOrWhiteSpace(values[3]) || !double.TryParse(values[3], out double pret))
                    {
                        LblPret.ForeColor = Color.Red;
                        LblProdus.ForeColor = Color.Red;
                        return;
                    }

                    LblPret.ForeColor = Color.Black;
                    LblProdus.ForeColor = Color.Black;
                    LblText.Text = null;

                    lines[i] = string.Join(",", values);
                    break;
                }
            }

            File.WriteAllLines(filePathProduseTxt, lines);

            TxtPret.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(TxtCategorie.Text) || string.IsNullOrWhiteSpace(TxtDenumire.Text) || string.IsNullOrWhiteSpace(TxtPret.Text))
                LblProdus.ForeColor = Color.Red;

            BtnEditPret.Visible = true;
            BtnEditCategorie.Visible = true;
            BtnEditDenumire.Visible = true;

            BtnSavePret.Visible = false;
            BtnCalc.Visible = false;
        }

        private void LblText_Click(object sender, EventArgs e)
        {
            LblText.Text = null;
        }

        private void FormEditareProdus_Load(object sender, EventArgs e)
        {
            BtnEditCategorie.Visible = false;
            BtnEditDenumire.Visible = false;
            BtnEditPret.Visible = false;
            BtnSaveCategorie.Visible = false;
            BtnSaveDenumire.Visible = false;
            BtnSavePret.Visible = false;
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

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {
            TxtCategorie.Text = null;
            TxtDenumire.Text = null;
            TxtPret.Text = null;

            BtnSearch.Visible = true;

            BtnClear.Visible = false;
            BtnEditCategorie.Visible = false;
            BtnSaveCategorie.Visible = false;
            BtnSaveDenumire.Visible = false;
            BtnEditPret.Visible = false;
            BtnEditDenumire.Visible = false;
            BtnSavePret.Visible = false;
            BtnCalc.Visible = false;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
