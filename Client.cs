using System.IO;
using System.Windows.Forms;

namespace Magazin
{
    internal class Client
    {
        public string CodClient { get; set; }
        public string NumeClient { get; set; }
        public string PrenumeClient { get; set; }
        public double SumaClient { get; set; }

        public static string FilePath = "../../../Clienti.txt";

        public Client(string codClient, string numeClient, string prenumeClient, double sumaClient)
        {
            CodClient = codClient;
            NumeClient = numeClient;
            PrenumeClient = prenumeClient;
            SumaClient = sumaClient;
        }

        public override string ToString()
        {
            return $"{CodClient},{NumeClient},{PrenumeClient},{SumaClient}";
        }

        public static void ClearFields(TextBox txtCodClient, TextBox txtNume, TextBox txtPrenume, TextBox txtSuma)
        {
            txtCodClient.Clear();
            txtNume.Clear();
            txtPrenume.Clear();
            txtSuma.Clear();
        }

        public static bool ClientExists(string clientCodPersonal, string filePathClientiTxt)
        {
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

        public static void AfisareClientiDgv(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowHeadersVisible = false;

            DataGridViewTextBoxColumn columnCodPersonal = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cod Personal",
                Width = 125
            };
            dgv.Columns.Add(columnCodPersonal);

            DataGridViewTextBoxColumn columnNume = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nume",
                Width = 116
            };
            dgv.Columns.Add(columnNume);

            DataGridViewTextBoxColumn columnPrenume = new DataGridViewTextBoxColumn
            {
                HeaderText = "Prenume",
                Width = 116
            };
            dgv.Columns.Add(columnPrenume);

            DataGridViewTextBoxColumn columnSuma = new DataGridViewTextBoxColumn
            {
                HeaderText = "Suma cheltuită",
                Width = 125
            };
            dgv.Columns.Add(columnSuma);

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

                            dgv.Rows.Add(codPersonal, nume, prenume, suma);
                        }
                    }
                }
            }
        }
    }
}
