using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BotAutoTrading.Utils
{
    public class ExportToExcell
    {
        public static void Export(DataGridView dataGridView, string filePath)
        {
            try
            {

                Excel._Application xlApp = new Excel.Application();
                // creating new WorkBook within Excel application  
                Excel._Workbook xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Excel._Worksheet xlWorksheet = null;
                // see the excel sheet behind the program  
                xlApp.Visible = false;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                xlWorksheet = xlWorkbook.Sheets["Sheet1"];
                xlWorksheet = xlWorkbook.ActiveSheet;

                // changing the name of active sheet  
                xlWorksheet.Name = "Exported";

                DataGridViewColumn[] columns = dataGridView.Columns.Cast<DataGridViewColumn>().ToArray();
                string header = string.Empty;
                // storing header part in Excel  
                foreach (DataGridViewColumn col in columns)
                {
                    xlWorksheet.Cells[1, col.Index + 1] = col.HeaderText;
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells.Cast<DataGridViewCell>().ToList().ForEach(cell =>
                    {
                        if (cell.Value == null)
                            xlWorksheet.Cells[cell.RowIndex + 2, cell.ColumnIndex + 1] = DBNull.Value;
                        else
                            xlWorksheet.Cells[cell.RowIndex + 2, cell.ColumnIndex + 1] = cell.Value.ToString();
                    });
                }

                // save the application  
                xlWorkbook.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
