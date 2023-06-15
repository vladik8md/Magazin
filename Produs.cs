using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Magazin
{
    internal class Produs
    {
        public int CodProdus { get; set; }
        public string CategorieProdus { get; set; }
        public string DenumireProdus { get; set; }
        public double PretProdus { get; set; }

        public static string FilePathCategorii = "../../../Categorii.txt";
        public static string FilePathProduse = "../../../Produse.txt";

        public Produs(int codProdus, string categorieProdus, string denumireProdus, double pretProdus)
        {
            CodProdus = codProdus;
            CategorieProdus = categorieProdus;
            DenumireProdus = denumireProdus;
            PretProdus = pretProdus;
        }

        public override string ToString()
        {
            return $"{CodProdus},{CategorieProdus},{DenumireProdus},{PretProdus}";
        }

        public static void CheckCategorii()
        {
            if (!File.Exists(FilePathCategorii))
            {
                using (File.Create(FilePathCategorii)) { }
            }

            if (!File.Exists(FilePathProduse))
            {
                using (File.Create(FilePathProduse)) { }
            }

            List<string> categorii = File.ReadAllLines(FilePathCategorii).ToList();

            List<string> categoriiFolosite = File.ReadLines(FilePathProduse)
                                              .Select(line => line.Split(',')[1].Trim())
                                              .Distinct()
                                              .ToList();

            List<string> unusedCategories = categorii.Except(categoriiFolosite).ToList();

            if (unusedCategories.Count > 0)
            {
                List<string> remainingCategories = categorii.Except(unusedCategories).ToList();
                File.WriteAllLines(FilePathCategorii, remainingCategories);
            }
        }

        public static void ClearFields(ComboBox cbCategorie, TextBox txtDenumire, TextBox txtPret)
        {
            cbCategorie.Text = string.Empty;
            txtDenumire.Clear();
            txtPret.Clear();
        }

        public static int NextCod(string filePathProduseTxt)
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

        public bool CategorieExists(string categorie, string filePathCategoriiTxt)
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

        public static void SaveCategorii(string filePath, List<string> categorii)
        {
            File.WriteAllLines(filePath, categorii);
        }

        public static void LoadCategorie(ComboBox comboBox)
        {
            if (File.Exists(FilePathCategorii))
            {
                string[] categorii = File.ReadAllLines(FilePathCategorii);
                comboBox.Items.AddRange(categorii);
            }
        }

        public static void AfisareProduseDgv(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowHeadersVisible = false;

            DataGridViewTextBoxColumn columnCod = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cod",
                Width = 60
            };
            dgv.Columns.Add(columnCod);

            DataGridViewTextBoxColumn columnCategorie = new DataGridViewTextBoxColumn
            {
                HeaderText = "Categorie",
                Width = 120
            };
            dgv.Columns.Add(columnCategorie);

            DataGridViewTextBoxColumn columnDenumire = new DataGridViewTextBoxColumn
            {
                HeaderText = "Denumire",
                Width = 242
            };
            dgv.Columns.Add(columnDenumire);

            DataGridViewTextBoxColumn columnPret = new DataGridViewTextBoxColumn
            {
                HeaderText = "Preț",
                Width = 60
            };
            dgv.Columns.Add(columnPret);

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

                            dgv.Rows.Add(cod, categorie, denumire, pret);
                        }
                    }
                }
            }
        }
    }
}
