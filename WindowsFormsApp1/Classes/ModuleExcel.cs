using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Objectcreator
{
    class moduleExcel
    {
        Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
        public void ExcelExport(DataGridView data)
        {
            for (int i = 1; i < data.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = data.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    XcelApp.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                }
            }
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }
    }
}