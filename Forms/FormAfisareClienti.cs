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
using System.Xml;

namespace Magazin_UI.Forms
{
    public partial class FormAfisareClienti : Form
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

        public FormAfisareClienti()
        {
            InitializeComponent();
        }

        private void FormAfisareClient_Load(object sender, EventArgs e)
        {
            AfisareClientiDgv();
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

        private void AfisareClientiDgv()
        {
            DgvClienti.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvClienti.RowHeadersVisible = false;

            DataGridViewTextBoxColumn columnCodPersonal = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cod Personal",
                Width = 125
            };
            DgvClienti.Columns.Add(columnCodPersonal);

            DataGridViewTextBoxColumn columnNume = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nume",
                Width = 116
            };
            DgvClienti.Columns.Add(columnNume);

            DataGridViewTextBoxColumn columnPrenume = new DataGridViewTextBoxColumn
            {
                HeaderText = "Prenume",
                Width = 116
            };
            DgvClienti.Columns.Add(columnPrenume);

            DataGridViewTextBoxColumn columnSuma = new DataGridViewTextBoxColumn
            {
                HeaderText = "Suma cheltuită",
                Width = 125
            };
            DgvClienti.Columns.Add(columnSuma);

            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            string grandParentDirectory = Directory.GetParent(parentDirectory)?.FullName;
            string greatGrandParentDirectory = Directory.GetParent(grandParentDirectory)?.FullName;

            if (greatGrandParentDirectory != null)
            {
                string targetFolder = Path.GetFullPath(greatGrandParentDirectory);
                string filePath = Path.Combine(targetFolder, "Clienti.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');

                        if (values.Length >= 4)
                        {
                            string codPersonal = values[0];
                            string nume = values[1];
                            string prenume = values[2];
                            string suma = values[3];

                            DgvClienti.Rows.Add(codPersonal, nume, prenume, suma);
                        }
                    }
                }
            }
        }
    }
}
