using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace Thslating
{
    public partial class Form1 : Form


    {
        private List<string> lstColumns = new List<string>();
        private List<string> lstColumnsForTranslate = new List<string>();
        private List<CellElement> sheetData;
        private string sheetName = "";
        private class RowElement
        {
            public List<CellElement> CellElement;
        }
        private class CellElement
        {
            public string Name;
            public string Value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Translate Text using Google Translate API's
        /// Google URL - http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="languagePair">2 letter Language Pair, delimited by "|".
        /// E.g. "ar|en" language pair means to translate from Arabic to English</param>
        /// <returns>Translated to String</returns>
        public string TranslateGoogleText(
            string input,
            string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;

            string result = webClient.DownloadString(url);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(result);
            string innerText1 = doc.DocumentNode.SelectSingleNode("//body").SelectNodes("//span").Single(n => n.Attributes.Any(a => a.Name == "id" && a.Value == "result_box")).InnerText;

            result = innerText1;

            // result = result.Substring(result.IndexOf("id=result_box") + 22, result.IndexOf("id=result_box") + 500);
            //  result = result.Substring(0, result.IndexOf("</div"));
            return result;
        }
        public string TranslateYandexText(
         string input,
         string language)
        {
            string userKey = "trnsl.1.1.20141017T075601Z.8466c9109acea7a9.43d3aaa48f8730c642fb563b8676aefcb3536aba";
            string url = String.Format("https://translate.yandex.net/api/v1.5/tr/translate?key={0}&text={1}&lang={2}", userKey, input, language);

            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;

            string result = webClient.DownloadString(url);
            string output = "";
            using (XmlReader reader = XmlReader.Create(new StringReader(result)))
            {
                reader.ReadToFollowing("text");
                output = reader.ReadElementContentAsString();
            }

            return output;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = TranslateGoogleText(this.textBox1.Text, "ru|en");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = TranslateYandexText(this.textBox1.Text, "ru-en");
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();

            dlgOpenFile.InitialDirectory = Application.ExecutablePath.ToString();
            dlgOpenFile.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            dlgOpenFile.FilterIndex = 1;
            dlgOpenFile.RestoreDirectory = true;

            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application ExcelApplication = new Excel.Application();
                this.tbxExcelFile.Text = dlgOpenFile.FileName.ToString();
                Excel.Workbook theWorkbook = ExcelApplication.Workbooks.Open(dlgOpenFile.FileName, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, false, false);
                Excel.Sheets sheets = theWorkbook.Worksheets;
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                sheetName = worksheet.Name;
                
                tbxSheetName.Text = sheetName;
                tbxTranslatedSheet.Text = sheetName;
                tbxTranslatedExcel.Text = dlgOpenFile.FileName.ToString();

                lstColumns = GetColumnsFromExcel(worksheet);
            
                
                //sheetData = new List<CellElement>();
                //sheetData = GetDataFromExcelSheet(worksheet, lstColumns);

                this.lbxExcelColumns.Items.Clear();
                foreach (var item in lstColumns)
                {
                    this.lbxExcelColumns.Items.Add(item);
                }
                this.lbxExcelColumns.Refresh();
                this.lbxForTranslate.Items.Clear();
                this.lbxForTranslate.Refresh();

                while (Marshal.ReleaseComObject(theWorkbook) > 0)
                { }
                while (Marshal.ReleaseComObject(theWorkbook) > 0)
                { }


                ExcelApplication.Quit();

                while (Marshal.ReleaseComObject(ExcelApplication) > 0)
                { }

                MessageBox.Show("Data readed");
            }
        }

        private List<CellElement> GetDataFromExcelSheet(Excel.Worksheet sheet, List<string> columnsList)
        {
            var lstRows = new List<CellElement>();

            int rowCount = sheet.UsedRange.Rows.Count;
            int columnCount = sheet.UsedRange.Columns.Count;
            var cellElem = new CellElement();
            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    lstRows.Add(new CellElement { Name = columnsList[j-1], Value = ((sheet.Cells[i, j].Value == null) ? "" : sheet.Cells[i, j].Value == null).ToString() });
                }
            }


            return lstRows;

        }
        private List<string> GetColumnsFromExcel(Excel.Worksheet sheet)
        {
            int rowCount = sheet.UsedRange.Rows.Count;
            int columnCount = sheet.UsedRange.Columns.Count;

            var columnValue = new List<string>();

            for (int i = 1; i <= columnCount; i++)
            {
                columnValue.Add(sheet.Cells[1,i].Value.ToString());
            }

            return columnValue;
        }

        private void btnToTranslate_Click(object sender, EventArgs e)
        {
            lbxForTranslate.Items.Add(lbxExcelColumns.SelectedItem);
            lstColumnsForTranslate.Add(lbxExcelColumns.SelectedValue.ToString());
        }

        private void btnFromTranslate_Click(object sender, EventArgs e)
        {
            lbxForTranslate.Items.Remove(lbxForTranslate.SelectedItem);
            lstColumnsForTranslate.Remove(lbxExcelColumns.SelectedValue.ToString());
        }

        private void btnTranslateToExcel_Click(object sender, EventArgs e)
        {

     
            var filename = tbxTranslatedExcel.Text;

            Excel.Application objExcel = new Excel.Application();
            objExcel.ScreenUpdating = false;
            objExcel.DisplayAlerts = false;
            objExcel.Workbooks.Add();
            Excel.Workbook objWorkbook = objExcel.Workbooks[1];
            Excel.Worksheet objSheet = (Excel.Worksheet)objWorkbook.Sheets.get_Item(1);
            objSheet.Name = tbxTranslatedSheet.Text;

            for (int i = 1; i <= lstColumns.Count; i++)
            {
                objSheet.Cells[1, i].Value = lstColumns[i];
            }

            Excel.Application ExcelApplication = new Excel.Application();
              Excel.Workbook theWorkbook = ExcelApplication.Workbooks.Open(tbxExcelFile.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, false, false);
            Excel.Sheets sheets = theWorkbook.Worksheets;
            Excel.Worksheet sheet = (Excel.Worksheet)sheets.get_Item(1);


            int rowCount = sheet.UsedRange.Rows.Count;
            int columnCount = sheet.UsedRange.Columns.Count;
            var cellElem = new CellElement();
            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    cellElem = new CellElement { Name = lstColumns[j - 1], Value = ((sheet.Cells[i, j].Value == null) ? "" : sheet.Cells[i, j].Value == null).ToString() };
                    if (lstColumnsForTranslate.Contains(cellElem.Name))
                    {
                        cellElem.Value = TranslateGoogleText(cellElem.Value, "ru|en");
                    }
                    objSheet.Cells[i, j].Value = cellElem.Value;
                }
            }
                objWorkbook.SaveAs();
                objWorkbook.SaveAs(tbxExcelFile.Text, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);

                objWorkbook.Close();
                theWorkbook.Close();
                while (Marshal.ReleaseComObject(objWorkbook) > 0)
                { }
                while (Marshal.ReleaseComObject(objWorkbook) > 0)
                { }
                while (Marshal.ReleaseComObject(theWorkbook) > 0)
                { }
                while (Marshal.ReleaseComObject(theWorkbook) > 0)
                { }

                    objExcel.Quit();

                while (Marshal.ReleaseComObject(objExcel) > 0)
                { }

                ExcelApplication.Quit();

                while (Marshal.ReleaseComObject(ExcelApplication) > 0)
                { }
                MessageBox.Show("Перевод окончен");
        }
    }
}
