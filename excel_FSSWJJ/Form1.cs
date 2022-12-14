
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace excel_FSSWJJ

{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);


                xlSheet = xlWB.ActiveSheet;


                CreateTable();


                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");


                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

            void CreateTable()
            {
                string[] fejlecek = new string[]
                {
                 "Kérdés",
                "Válasz1",
                "Válasz2",
                "Válasz3",
                "Helyes válasz",
                "kép"
            };
                for (int i = 0; i < fejlecek.Length; i++)
                {
                    xlSheet.Cells[1, i + 1] = fejlecek[i];
                }


                Models.HajosContext context = new Models.HajosContext();
                var kerdesek = context.Questions.ToList();

                object[,] adat = new object[kerdesek.Count(), fejlecek.Count()];

                for (int i = 0; i < kerdesek.Count(); i++)
                {
                    adat[i, 0] = kerdesek[i].Question1;
                    adat[i, 1] = kerdesek[i].Answer1;
                    adat[i, 2] = kerdesek[i].Answer2;
                    adat[i, 3] = kerdesek[i].Answer3;
                    adat[i, 4] = kerdesek[i].CorrectAnswer;
                    adat[i, 5] = kerdesek[i].Image;
                }

                int sorszam = adat.GetLength(0);
                int oszlopszam = adat.GetLength(1);

                Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorszam, oszlopszam);
                adatRange.Value2 = adat;

                adatRange.Columns.AutoFit();

                Excel.Range fejlec = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
                fejlec.Font.Bold = true;
                fejlec.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                fejlec.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                fejlec.EntireColumn.AutoFit();
                fejlec.RowHeight = 30;
                fejlec.Interior.Color = Color.Green;
                fejlec.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            }
        }
    }
}