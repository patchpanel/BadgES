using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgES.Core.Util
{
    public class ExcelImporter
    {
        public int ImportResourceList(String ConnectionString, String Workbook)
        {
           
           //Workbook wb = new Workbook();
           //wb.Open("C:\repositories\BadgES\Files\Badge_GDC Manila Resource List template v3.xlsx");
           //Worksheet ws = wb.Worksheets[0];

           //DataTable dt = ws.Cells.ExportDataTable(0, 0, trows, tcols, true);

           // Creating a file stream containing the Excel file to be opened
           //FileStream fstream = new FileStream(dataDir + "Badge_GDC Manila Resource List template v3.xlsx", FileMode.Open);
           FileStream fstream = new FileStream(Workbook, FileMode.Open);
            // Instantiating a Workbook object
            // Opening the Excel file through the file stream
            Workbook workbook = new Workbook(fstream);

            // Accessing the first worksheet in the Excel file
            Worksheet worksheet = workbook.Worksheets[0];
            int trows = worksheet.Cells.MaxDataRow;
            int tcols = 5;//worksheet.Cells.MaxDataColumn;
            // Exporting the contents of 7 rows and 2 columns starting from 1st cell to DataTable
            //Badge Report V3
            //System.Data.DataTable dt = worksheet.Cells.ExportDataTable(0, 0, 452, 5, true);
            //Badge Report V3
            System.Data.DataTable dt = worksheet.Cells.ExportDataTable(0, 0, trows, tcols, true);
            dt.TableName = "s_ResourceList";
            System.Console.WriteLine("Number of Rows in Data Table: " + dt.Rows.Count);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in dt.Columns)
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    bulkCopy.DestinationTableName = dt.TableName;
                    bulkCopy.WriteToServer(dt);

                }
            }
            // Closing the file stream to free all resources
            fstream.Close();
            return 0;
        }
    }
}
