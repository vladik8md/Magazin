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
    public partial class FormAfisareProduse : Form
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

        public FormAfisareProduse()
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

        private void FormAfisareProduse_Load(object sender, EventArgs e)
        {
            AfisareProduseDgv();
        }

        private void AfisareProduseDgv()
        {
            DgvProduse.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvProduse.RowHeadersVisible = false;

            DataGridViewTextBoxColumn columnCod = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cod",
                Width = 60
            };
            DgvProduse.Columns.Add(columnCod);

            DataGridViewTextBoxColumn columnCategorie = new DataGridViewTextBoxColumn
            {
                HeaderText = "Categorie",
                Width = 120
            };
            DgvProduse.Columns.Add(columnCategorie);

            DataGridViewTextBoxColumn columnDenumire = new DataGridViewTextBoxColumn
            {
                HeaderText = "Denumire",
                Width = 242
            };
            DgvProduse.Columns.Add(columnDenumire);

            DataGridViewTextBoxColumn columnPret = new DataGridViewTextBoxColumn
            {
                HeaderText = "Preț",
                Width = 60
            };
            DgvProduse.Columns.Add(columnPret);

            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            string grandParentDirectory = Directory.GetParent(parentDirectory)?.FullName;
            string greatGrandParentDirectory = Directory.GetParent(grandParentDirectory)?.FullName;

            if (greatGrandParentDirectory != null)
            {
                string targetFolder = Path.GetFullPath(greatGrandParentDirectory);
                string filePath = Path.Combine(targetFolder, "Produse.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');

                        if (values.Length >= 4)
                        {
                            string cod = values[0];
                            string categorie = values[1];
                            string denumire = values[2];
                            string pret = values[3];

                            DgvProduse.Rows.Add(cod, categorie, denumire, pret);
                        }
                    }
                }
            }
        }
    }
}
