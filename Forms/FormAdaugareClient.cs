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
    public partial class FormAdaugareClient : Form
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

        private void ClearFields()
        {
            TxtCodPersonal.Text = string.Empty;
            TxtNume.Text = string.Empty;
            TxtPrenume.Text = string.Empty;
            TxtSuma.Text = string.Empty;
        }

        public FormAdaugareClient()
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

        private void FormAdaugareClient_Load(object sender, EventArgs e)
        {
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

        private void BtnAdaugaClient_Click(object sender, EventArgs e)
        {
            string folderPathClienti = "../../../";
            string fileNameClienti = "Clienti.txt";
            string filePathClientiTxt = Path.Combine(folderPathClienti, fileNameClienti);

            string clientCodPersonal = TxtCodPersonal.Text;
            string clientNume = TxtNume.Text;
            string clientPrenume = TxtPrenume.Text;
            string clientSuma = TxtSuma.Text;

            if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && !string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && !string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && !string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && !string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && !string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && !string.IsNullOrWhiteSpace(clientSuma))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (ClientExists(clientCodPersonal))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Black;
                LblText.Text = $"Clientul cu codul personal '{clientCodPersonal}' deja există în fișierul 'Clienti.txt'";
                return;
            }
            else
            {
                LblClient.ForeColor = Color.Black;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Black;
            }

            string valuesProduse = $"{clientCodPersonal},{clientNume},{clientPrenume},{clientSuma}";

            using (StreamWriter writer = File.AppendText(filePathClientiTxt))
            {
                writer.WriteLine(valuesProduse);
            }

            LblText.Text = $"Produsul a fost salvat în 'Clienti.txt' cu codul personal '{clientCodPersonal}'";
            ClearFields();
        }

        private bool ClientExists(string clientCodPersonal)
        {
            string folderPathClienti = "../../../";
            string fileNameClienti = "Clienti.txt";
            string filePathClientiTxt = Path.Combine(folderPathClienti, fileNameClienti);

            if (File.Exists(filePathClientiTxt))
            {
                using (StreamReader reader = new StreamReader(filePathClientiTxt))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        if (values.Length >= 1 && values[0] == clientCodPersonal)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void LblText_Click(object sender, EventArgs e)
        {
            LblText.Text = null;
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

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
