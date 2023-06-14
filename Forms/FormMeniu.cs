using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormMeniu : Form
    {
        public static void CheckCategorii()
        {
            string folderPathCategorii = "../../../";
            string fileNameCategorii = "Categorii.txt";
            string filePathCategoriiTxt = Path.Combine(folderPathCategorii, fileNameCategorii);

            if (!File.Exists(filePathCategoriiTxt))
            {
                using (File.Create(filePathCategoriiTxt)) { }
            }

            string fileNameProduse = "Produse.txt";
            string filePathProduseTxt = Path.Combine(folderPathCategorii, fileNameProduse);

            if (!File.Exists(filePathProduseTxt))
            {
                using (File.Create(filePathProduseTxt)) { }
            }

            List<string> categorii = File.ReadAllLines(filePathCategoriiTxt).ToList();

            List<string> categoriiFolosite = File.ReadLines(filePathProduseTxt)
                                              .Select(line => line.Split(',')[1].Trim())
                                              .Distinct()
                                              .ToList();

            List<string> unusedCategories = categorii.Except(categoriiFolosite).ToList();

            if (unusedCategories.Count > 0)
            {
                List<string> remainingCategories = categorii.Except(unusedCategories).ToList();
                File.WriteAllLines(filePathCategoriiTxt, remainingCategories);
            }
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

        public FormMeniu()
        {
            InitializeComponent();
        }

        private void BtnProduse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduse());
        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClienti());
        }

        private void FormMeniu_Load(object sender, EventArgs e)
        {
            CheckCategorii();    
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
