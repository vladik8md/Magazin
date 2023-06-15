using Magazin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void FormAdaugareProdus_Load(object sender, EventArgs e)
        {
            Produs.LoadCategorie(CbCategorie);

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

        public FormAdaugareProdus()
        {
            InitializeComponent();
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            LblCategorieText.Text = string.Empty;
            LblText.Text = string.Empty;

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

            int produsCod = Produs.NextCod(Produs.FilePathProduse);

            Produs produs = new Produs(produsCod, produsCategorie, produsDenumire, double.Parse(TxtPret.Text));

            using (StreamWriter writer = File.AppendText(Produs.FilePathProduse))
            {
                writer.WriteLine(produs);
            }

            if (!string.IsNullOrEmpty(CbCategorie.Text) && !produs.CategorieExists(produsCategorie, Produs.FilePathCategorii))
            {
                CbCategorie.Items.Add(produsCategorie);
                Produs.SaveCategorii(Produs.FilePathCategorii, CbCategorie.Items.OfType<string>().ToList());
                LblCategorieText.Text = $"Categoria '{produsCategorie}' a fost adăugată în fișierul 'Categorii.txt'.";
            }

            LblText.Text = $"Produsul a fost salvat în 'Produse.txt' cu codul '{produsCod}'";

            Produs.ClearFields(CbCategorie, TxtDenumire, TxtPret);
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
