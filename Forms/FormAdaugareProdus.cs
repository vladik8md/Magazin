using Magazin;
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

        private int NextCod()
        {
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
            filePathCategoriiTxt = GetFilePath(FilePathOption.Categorii);
            filePathProduseTxt = GetFilePath(FilePathOption.Produse);
            InitializeComponent();
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            string produsCategorie = CbCategorie.Text;
            string produsDenumire = TxtDenumire.Text;
            string produsPret = Convert.ToString(TxtPret.Text);

            if (string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && (string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out double pret)))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && (string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out pret)))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Black;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(produsCategorie) && !string.IsNullOrWhiteSpace(produsDenumire) && (string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out pret)))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Black;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(produsCategorie) && !string.IsNullOrWhiteSpace(produsDenumire) && (!string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out pret)))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Black;
                return;
            }
            else if (string.IsNullOrWhiteSpace(produsCategorie) && !string.IsNullOrWhiteSpace(produsDenumire) && (string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out pret)))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Black;
                LblPret.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && (!string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out pret)))
            {
                LblProdus.ForeColor = Color.Red;
                LblCategorie.ForeColor = Color.Red;
                LblDenumire.ForeColor = Color.Red;
                LblPret.ForeColor = Color.Black;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(produsCategorie) && string.IsNullOrWhiteSpace(produsDenumire) && (!string.IsNullOrWhiteSpace(produsPret) || !double.TryParse(produsPret, out pret)))
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

            Produs produs = new Produs(produsCod, produsCategorie, produsDenumire, double.Parse(TxtPret.Text));

            using (StreamWriter writer = File.AppendText(filePathProduseTxt))
            {
                writer.WriteLine(produs);
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
            File.WriteAllLines(filePathCategoriiTxt, CbCategorie.Items.OfType<string>());
        }

        private void LoadCategorii()
        {
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
