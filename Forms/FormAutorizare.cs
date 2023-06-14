using System;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;

namespace Magazin_UI.Forms
{
    public partial class FormAutorizare : Form
    {
        private int loginAttempts = 0;
        private readonly TelegramBotClient botClient;
        private readonly string botToken = "5900642493:AAGbGw9kHg_8XVO4ZThs01CWpXILM9rwpIs";
        private readonly string chatId = "-1001760055401";

        public FormAutorizare()
        {
            InitializeComponent();
            botClient = new TelegramBotClient(botToken);
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

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string loginFilePath = "login.txt";
            string login = File.ReadAllText(loginFilePath);
            string passwordFilePath = "password.txt";
            string password = File.ReadAllText(passwordFilePath);

            string enterLogin = TxtLogin.Text;
            string enterPassword = TxtPassword.Text;

            if (login == enterLogin && password == enterPassword)
            {
                OpenChildForm(new FormMeniu());
            }
            else
            {
                loginAttempts++;

                if (loginAttempts >= 1)
                {
                    string ipAddress = GetIPAddress();
                    string machineName = GetMachineName();
                    string osVersion = GetOSVersion();
                    DateTime date = DateTime.Now;

                    string message = $"Încercare nereușită - CrossDrive\nData: {date}\nIP: {ipAddress}\nNumele utilizatorului: {machineName}\nOS: {osVersion}";
                    botClient.SendTextMessageAsync(chatId, message);
                    MessageBox.Show("Login failed.");
                    Application.Exit();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAutorizare_Load(object sender, EventArgs e)
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

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            TxtLogin.PasswordChar = '*';
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }

        private string GetIPAddress()
        {
            string ipAddress = string.Empty;
            System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (System.Net.IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }
            return ipAddress;
        }

        private string GetMachineName()
        {
            return Environment.MachineName;
        }

        private string GetOSVersion()
        {
            return Environment.OSVersion.VersionString;
        }
    }
}