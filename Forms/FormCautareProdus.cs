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
    public partial class FormCautareProdus : Form
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

        public FormCautareProdus()
        {
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
            string folderPathProduse = "../../../";
            string fileNameProduse = "Produse.txt";
            string filePathProduseTxt = Path.Combine(folderPathProduse, fileNameProduse);

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

            BtnSearch.Visible = true;

            LblProdus.ForeColor = Color.Black;
            LblCod.ForeColor = Color.Black;
            LblText.Text = null;
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
        }

        private void FormCautareProdus_Load(object sender, EventArgs e)
        {
            BtnClear.Visible = false;
        }
    }
}
