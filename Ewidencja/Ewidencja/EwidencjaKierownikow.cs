using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Ewidencja
{
    public partial class EwidencjaKierownikow : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;
        private bool ifLoadingCancel;

        public void setIfLoadingCancel(bool ifLoadingCancel)
        {
            this.ifLoadingCancel = ifLoadingCancel;
        }
        public bool getIfLoadingCancel()
        {
            return ifLoadingCancel;
        }

        private Boolean isFirstFileLoad = false, isSecondFileLoad = false, isThirdFileLoad = false;
        public List<Person> AllMenagersAndTrains { get; set; }
        public List<Person> FirstMenagersAndTrains { get; set; }
        public List<Person> SecondMenagersAndTrains { get; set; }

        private List<Person> LoadToListAllMenagers(int firstRow, int firstColumn, int lastColumn)
        {
            int rowCount = xlRange.Rows.Count;

            String name = "", vehicles = "";
            var list = new List<Person>();

            for (int i = firstRow; i <= rowCount; i++)
            {

                for (int j = firstColumn; j <= lastColumn; j++)
                {
                    if (j == firstColumn)
                    {
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                            name = (xlRange.Cells[i, j].Value2.ToString());
                    }
                    else if (j == lastColumn)
                    {
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                            vehicles = (xlRange.Cells[i, j].Value2.ToString());
                    }

                }

                list.Add(new Person()
                {
                    nameAndSurname = name,
                    vehicles = vehicles
                });
            }

            return list;
        }
        private List<Person> LoadToListFirsAndSecondMenagers(int firstRow, int trainColumn, int Workers)
        {
            int rowCount = xlRange.Rows.Count;

            String name = "", vehicles = "";
            var list = new List<Person>();

            for (int i = firstRow; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, Workers] != null && xlRange.Cells[i, Workers].Value2 != null)
                {
                    name = (xlRange.Cells[i, Workers].Value2.ToString());
                }
                else
                {
                    continue;
                }

                vehicles = "";

                if (xlRange.Cells[i, trainColumn] == null && xlRange.Cells[i, trainColumn].Value2 == null && trainColumn == trainColumn)
                {
                    vehicles = "";
                }
                else if (xlRange.Cells[i, trainColumn] != null && xlRange.Cells[i, trainColumn].Value2 != null)
                {
                    vehicles = (xlRange.Cells[i, trainColumn].Value2.ToString());
                }

                list.Add(new Person()
                {
                    nameAndSurname = name,
                    vehicles = vehicles
                });

            }
            return list;

        }


        public EwidencjaKierownikow()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            datePicker.Value = thisDay;
        }

        Excel.Application CreateExcelApplication()
        {
            Excel.Application xlApp = new Excel.Application();
            return xlApp;
        }
        Excel.Workbook CreateExcelWorkbook(Excel.Application xlApp, String filePath)
        {
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            return xlWorkbook;
        }
        Excel.Workbook CreateEmptyExcelWorkbook(Excel.Application xlApp)
        {
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
            return xlWorkbook;
        }
        Excel._Worksheet CreateExcelWorksheet(Excel.Workbook xlWorkbook)
        {
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            return xlWorksheet;
        }
        Excel.Range CreateExcelRange(Excel._Worksheet xlWorksheet)
        {
            Excel.Range xlRange = xlWorksheet.UsedRange;
            return xlRange;
        }
        void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close(true, Type.Missing, Type.Missing);
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void LoadExcelFile(String filePath)
        {
            xlApp = CreateExcelApplication();
            xlWorkbook = CreateExcelWorkbook(xlApp, filePath);
            xlWorksheet = CreateExcelWorksheet(xlWorkbook);
            xlRange = CreateExcelRange(xlWorksheet);
        }
        private void CreateExcelFiles(String filepath)
        {
            xlApp = CreateExcelApplication();
            xlWorkbook = CreateEmptyExcelWorkbook(xlApp);
            xlWorksheet = CreateExcelWorksheet(xlWorkbook);
            xlWorkbook.SaveAs(filepath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            xlRange = CreateExcelRange(xlWorksheet);
        }

        private void firstExcel_Click(object sender, EventArgs e)
        {
            setIfLoadingCancel(true);
            String filePath = getFilePath();
            if (getIfLoadingCancel())
            {
                label4.Text = "Wczytywanie. Proszę czekać...";
                LoadExcelFile(filePath);
                AllMenagersAndTrains = LoadToListAllMenagers(2, 10, 16);
                label4.Text = "Poprawnie wczytano plik " + getFileName(filePath);
                ClearMemory();
                isFirstFileLoad = true;
                isAbleToCreateNewFile();
            }
        }
        private void secondExcel_Click(object sender, EventArgs e)
        {
            setIfLoadingCancel(true);
            String filePath = getFilePath();
            if (getIfLoadingCancel())
            {
                label5.Text = "Wczytywanie. Proszę czekać...";
                LoadExcelFile(filePath);
                AllMenagersAndTrains.AddRange(LoadToListAllMenagers(2, 10, 16));
                label5.Text = "Poprawnie wczytano plik " + getFileName(filePath);
                ClearMemory();
                isSecondFileLoad = true;
                isAbleToCreateNewFile();
            }
        }
        private void thirdExcel_Click(object sender, EventArgs e)
        {
            setIfLoadingCancel(true);
            String filePath = getFilePath();
            if (getIfLoadingCancel())
            {
                label6.Text = "Wczytywanie. Proszę czekać...";
                LoadExcelFile(filePath);
                FirstMenagersAndTrains = LoadToListFirsAndSecondMenagers(6, 16, 41);
                SecondMenagersAndTrains = LoadToListFirsAndSecondMenagers(6, 16, 46);
                label6.Text = "Poprawnie wczytano plik " + getFileName(filePath);
                ClearMemory();
                isThirdFileLoad = true;
                isAbleToCreateNewFile();
            }
        }
        private void createExcel_Click(object sender, EventArgs e)
        {
            setIfLoadingCancel(true);
            String filePath = setFilePath();
            if (getIfLoadingCancel())
            {
                label1.Text = "Tworzenie pliku. Proszę czekać...";

                CreateExcelFiles(filePath);

                ReplaceSymbol(AllMenagersAndTrains);
                SortByName(AllMenagersAndTrains);
                SaveListsToExcel(AllMenagersAndTrains, 3, 2, 3);


                ReplaceSymbol(FirstMenagersAndTrains);
                SortByName(FirstMenagersAndTrains);
                ReverseSaveListsToExcel(FirstMenagersAndTrains, 3, 5, 6);


                ReplaceSymbol(SecondMenagersAndTrains);
                SortByName(SecondMenagersAndTrains);
                ReverseSaveListsToExcel(SecondMenagersAndTrains, 3, 8, 9);

                SheetFormatting();
                ClearMemory();

                label1.Text = "Obliczanie zgodności..";

                LoadExcelFile(filePath);
                CalculatingCompatibility();

                ClearMemory();

                label1.Text = "Poprawnie utworzono plik " + getFileName(filePath);
            }


        }

        private void isAbleToCreateNewFile()
        {
            if (isFirstFileLoad)
            {
                boxWithSecondFile.Enabled = true;
            }
            if (isFirstFileLoad && isSecondFileLoad)
            {
                boxWithThirdFile.Enabled = true;
            }
            if (isFirstFileLoad && isSecondFileLoad && isThirdFileLoad)
            {
                boxWithCreatingFile.Enabled = true;
            }
        }
        private void SortByName(List<Person> menagersList)
        {
            menagersList.Sort((x, y) => string.Compare(x.nameAndSurname, y.nameAndSurname));
        }
        private void ReplaceSymbol(List<Person> menagersList)
        {
            for (int i = 0; i < menagersList.Count; i++)
            {
                String trains = menagersList[i].vehicles;
                menagersList[i].vehicles = trains.Replace("-", " ");
            }
        }

        private void SaveListsToExcel(List<Person> Workers, int firstRow, int firstColumn, int lastColumn)
        {
            String names, vehicle;
            int countOfWorkers = 0;
            for (int i = firstRow; i <= (Workers.Count + 1); i++)
            {
                for (int j = firstColumn; j <= lastColumn; j++)
                {
                    if (j == firstColumn)
                    {

                        names = Workers[countOfWorkers].nameAndSurname;
                        xlRange.Cells[i, j].Value2 = names;

                    }
                    else if (j == lastColumn)
                    {

                        vehicle = Workers[countOfWorkers].vehicles;
                        xlRange.Cells[i, j].Value2 = vehicle;

                    }
                }
                countOfWorkers++;
            }
            xlWorkbook.Save();
        }
        private void ReverseSaveListsToExcel(List<Person> Workers, int firstRow, int firstColumn, int lastColumn)
        {
            String names, vehicle;
            int countOfWorkers = 0;
            for (int i = firstRow; i <= Workers.Count; i++)
            {
                for (int j = firstColumn; j <= lastColumn; j++)
                {
                    if (j == firstColumn)
                    {
                        vehicle = Workers[countOfWorkers].vehicles;
                        xlRange.Cells[i, j].Value2 = vehicle;

                    }
                    else if (j == lastColumn)
                    {
                        names = Workers[countOfWorkers].nameAndSurname;
                        xlRange.Cells[i, j].Value2 = names;

                    }
                }
                countOfWorkers++;
            }
            xlWorkbook.Save();
        }
        private void SheetFormatting()
        {
            String dateWithHour = datePicker.Value.ToString();
            String[] onlyDate = dateWithHour.Split(' ');

            List<String> titlesOfSheet = new List<string>();

            titlesOfSheet.Add("DPK " + onlyDate[0]);
            titlesOfSheet.Add("");
            titlesOfSheet.Add("");
            titlesOfSheet.Add("Dane z raportu ewidencja z dnia " + onlyDate[0]);
            titlesOfSheet.Add("");
            titlesOfSheet.Add("");
            titlesOfSheet.Add("Dane z raportu ewidencja z dnia " + onlyDate[0]);
            titlesOfSheet.Add("");
            titlesOfSheet.Add("");
            titlesOfSheet.Add("");
            titlesOfSheet.Add("");
            titlesOfSheet.Add("");
            titlesOfSheet.Add("Niezgodności");

            for (int i = 0; i < titlesOfSheet.Count; i++)
            {
                xlRange.Cells[1, i + 2].Value2 = titlesOfSheet[i];
            }

            List<String> titleOfTable = new List<string>();

            titleOfTable.Add("Pracownicy");
            titleOfTable.Add("Pojazdy");
            titleOfTable.Add("");
            titleOfTable.Add("Pojazdy");
            titleOfTable.Add("Kierownik 1");
            titleOfTable.Add("Wynik");
            titleOfTable.Add("Pojazdy");
            titleOfTable.Add("Kierownik 2");
            titleOfTable.Add("Wynik");

            for (int i = 0; i < titleOfTable.Count; i++)
            {
                xlRange.Cells[2, i + 2].Value2 = titleOfTable[i];
            }

            xlWorksheet.Columns[1].ColumnWidth = 4;
            xlWorksheet.Rows[1].RowHeight = 40;
            xlWorksheet.Columns[2].ColumnWidth = 30;
            xlWorksheet.Columns[3].ColumnWidth = 145;
            xlWorksheet.Columns[4].ColumnWidth = 16;
            xlWorksheet.Columns[5].ColumnWidth = 20;
            xlWorksheet.Columns[6].ColumnWidth = 25;
            xlWorksheet.Columns[7].ColumnWidth = 12;
            xlWorksheet.Columns[8].ColumnWidth = 20;
            xlWorksheet.Columns[9].ColumnWidth = 25;
            xlWorksheet.Columns[10].ColumnWidth = 12;
            xlWorksheet.Columns[11].ColumnWidth = 1;



            xlWorksheet.Range["M1:N1"].Merge();
            xlWorksheet.Range["B1:C1"].Merge();
            xlWorksheet.Range["E1:F1"].Merge();
            xlWorksheet.Range["H1:I1"].Merge();

        }
        private void CalculatingCompatibility()
        {
            int rowCount = xlRange.Rows.Count;

            for (int i = 3; i <= rowCount; i++)
            {
                String firstFormula = "=JEŻELI(CZY.BŁĄD(WYSZUKAJ.PIONOWO(LEWY(F" + i + "&\"*\"&E" + i + ",3)&\"*\"&PRAWY(N" + i + "&\"*\"&O" + i + ",3)&\"*\"&LEWY(E" + i + ",5)&\"*\",$B$3:$B$229&$C$3:$C$229,1,0)=\"\"),\"niezgodność\",\"OK\")";
                String secondFormula = "=JEŻELI(CZY.BŁĄD(WYSZUKAJ.PIONOWO(LEWY(I" + i + "&\"*\"&H" + i + ",3)&\"*\"&PRAWY(Q" + i + "&\"*\"&R" + i + ",3)&\"*\"&LEWY(H" + i + ",5)&\"*\",$B$3:$B$229&$C$3:$C$229,1,0)=\"\"),\"niezgodność\",\"OK\")";
                String thirdFormula = "=LICZ.JEŻELI(G3:G411,\"niezgodność\")+LICZ.JEŻELI(J3:J411,\"niezgodność\")";
                xlWorksheet.Range["O1"].FormulaArray = thirdFormula;
                xlWorksheet.Range["G" + i].FormulaArray = firstFormula;
                xlWorksheet.Range["J" + i].FormulaArray = secondFormula;

            }
        }

        private String getFilePath()
        {
            string filepath = "";
            loadFile.Filter = "Plik excel (*.xlsx) |*.xlsx";
            if (loadFile.ShowDialog() == DialogResult.Cancel)
            {
                setIfLoadingCancel(false);
            }
            else
            {
                filepath = loadFile.FileName;
            }
            return filepath;
        }
        private String getFileName(String filepath)
        {
            String filename = "";
            String[] pathElements;

            pathElements = filepath.Split('\\');

            filename = pathElements[pathElements.Length - 1];

            return filename;
        }
        private String setFilePath()
        {
            string filepath = "";
            saveFile.Filter = "Plik excel (*.xlsx) |*.xlsx";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
            {
                setIfLoadingCancel(false);
            }
            else
            {
                filepath = saveFile.FileName;
            }
            return filepath;
        }
    }
}
