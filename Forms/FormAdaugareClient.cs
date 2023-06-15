using Magazin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        private void BtnAdaugaClient_Click(object sender, EventArgs e)
        {
            LblText.Text = string.Empty;

            string clientCodPersonal = TxtCodPersonal.Text;
            string clientNume = TxtNume.Text;
            string clientPrenume = TxtPrenume.Text;
            string clientSuma = TxtSuma.Text;

            if (Client.ClientExists(clientCodPersonal, Client.FilePath))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Black;
                LblText.Text = $"Clientul cu codul personal '{clientCodPersonal}' deja există în fișierul 'Clienti.txt'";
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out double suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (!string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (!string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Red;
                LblPrenume.ForeColor = Color.Red;
                LblSuma.ForeColor = Color.Black;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Red;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (!string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
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
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && !string.IsNullOrWhiteSpace(clientPrenume) && (string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
            {
                LblClient.ForeColor = Color.Red;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Red;
                return;
            }
            else if (!string.IsNullOrWhiteSpace(clientCodPersonal) && !string.IsNullOrWhiteSpace(clientNume) && string.IsNullOrWhiteSpace(clientPrenume) && (!string.IsNullOrWhiteSpace(clientSuma) || !double.TryParse(clientSuma, out suma)))
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
            else
            {
                LblClient.ForeColor = Color.Black;
                LblCodPersonal.ForeColor = Color.Black;
                LblNume.ForeColor = Color.Black;
                LblPrenume.ForeColor = Color.Black;
                LblSuma.ForeColor = Color.Black;
            }

            Client client = new Client(clientCodPersonal, clientNume, clientPrenume, double.Parse(TxtSuma.Text));

            using (StreamWriter writer = File.AppendText(Client.FilePath))
            {
                writer.WriteLine(client);
            }

            LblText.Text = $"Produsul a fost salvat în 'Clienti.txt' cu codul personal '{clientCodPersonal}'";

            Client.ClearFields(TxtCodPersonal, TxtNume, TxtPrenume, TxtSuma);
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
