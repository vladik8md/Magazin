using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_UI.Forms
{
    public partial class FormAdaugareProdus : Form
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

        private int NextCod()
        {
            string folderPathProduse = "../../../";
            string fileNameProduse = "Produse.txt";
            string filePathProduseTxt = Path.Combine(folderPathProduse, fileNameProduse);

            if (!File.Exists(filePathProduseTxt))
            {
                using (File.Create(filePathProduseTxt)) { }
            }

            string[] linesFormProdus = File.ReadAllLines(filePathProduseTxt);
            if (linesFormProdus.Length == 0)
            {
                return 0;
            }
            else
            {
                int maxCode = linesFormProdus
                    .Select(lineFormProdus => int.Parse(lineFormProdus.Split(',')[0]))
                    .Max();
                return maxCode + 1;
            }
        }

        private void ClearFields()
        {
            CbCategorie.Text = string.Empty;
            TxtDenumire.Text = string.Empty;
            TxtPret.Text = string.Empty;
        }

        private bool CategorieExists(string categorie)
        {
            string folderPathCategorii = "../../../";
            string fileNameCategorii = "Categorii.txt";
            string filePathCategoriiTxt = Path.Combine(folderPathCategorii, fileNameCategorii);

            if (File.Exists(filePathCategoriiTxt))
            {
                string[] lines = File.ReadAllLines(filePathCategoriiTxt);
                foreach (string line in lines)
                {
                    if (line == categorie)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public FormAdaugareProdus()
        {
            InitializeComponent();
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            string folderPathProduse = "../../../";
            string fileNameProduse = "Produse.txt";
            string filePathProduseTxt = Path.Combine(folderPathProduse, fileNameProduse);

            string produsCategorie = CbCategorie.Text;
            string produsDenumire = TxtDenumire.Text;
            string produsPret = Convert.ToString(TxtPret.Text);

            if (string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Black;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(produsCategorie) && !string.IsNullOrWhiteSpace(produsDenumire) && string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Black;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(produsCategorie) && !string.IsNullOrWhiteSpace(produsDenumire) && !string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Black;
                return;
            }
            else if (string.IsNullOrWhiteSpace(produsCategorie) && !string.IsNullOrWhiteSpace(produsDenumire) && string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && !string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Black;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && !string.IsNullOrWhiteSpace(produsPret))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Black;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Black;
                return;
            }
            else
            {
                LblProdus.ForeColor = Color.Black;
                LblCategorie.ForeColor = Color.Black;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Black;
            }

            int produsCod = NextCod();

            string valuesProduse = $"{produsCod},{produsCategorie},{produsDenumire},{produsPret}";

            using (StreamWriter writer = File.AppendText(filePathProduseTxt))
            {
                writer.WriteLine(valuesProduse);
            }

            if (!string.IsNullOrEmpty(CbCategorie.Text) && !CategorieExists(produsCategorie))
            {
                CbCategorie.Items.Add(produsCategorie);
                SaveCategorie();
                LblCategorieText.Text = $"Categoria '{produsCategorie}' a fost adăugată în fișierul 'Categorii.txt'.";
            }

            LblText.Text = $"Produsul a fost salvat în 'Produse.txt' cu codul '{produsCod}'";
            ClearFields();
        }

        private void FormAdaugareProdus_Load(object sender, EventArgs e)
        {
            LoadCategorii();

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
                else if (control is ComboBox comboBox)
                {
                    comboBox.KeyDown += (s, ea) =>
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
            LblCategorieText.Text = null;    
        }

        private void LblCategorieText_Click(object sender, EventArgs e)
        {
            LblText.Text = null;
            LblCategorieText.Text = null;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMeniu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMeniu());
        }

        private void SaveCategorie()
        {
            string folderPathCategorii = "../../../";
            string fileNameCategorii = "Categorii.txt";
            string filePathCategoriiTxt = Path.Combine(folderPathCategorii, fileNameCategorii);

            File.WriteAllLines(filePathCategoriiTxt, CbCategorie.Items.OfType<string>());
        }

        private void LoadCategorii()
        {
            string folderPathCategorii = "../../../";
            string fileNameCategorii = "Categorii.txt";
            string filePathCategoriiTxt = Path.Combine(folderPathCategorii, fileNameCategorii);

            if (File.Exists(filePathCategoriiTxt))
            {
                string[] categorii = File.ReadAllLines(filePathCategoriiTxt);
                CbCategorie.Items.AddRange(categorii);
            }
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

        private void BtnCategoriiFile_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            string grandParentDirectory = Directory.GetParent(parentDirectory)?.FullName;
            string greatGrandParentDirectory = Directory.GetParent(grandParentDirectory)?.FullName;

            if (greatGrandParentDirectory != null)
            {
                string targetFolder = Path.GetFullPath(greatGrandParentDirectory);
                string filePath = Path.Combine(targetFolder, "Categorii.txt");
                Process.Start(filePath);
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
