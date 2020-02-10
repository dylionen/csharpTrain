using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GetDataFromEXCEL
    {
        private ExcelPackage package;
        private ExcelWorksheet excelWorksheet;
        private bool isConnected;
        public GetDataFromEXCEL(String localization)
        {
            isConnected = setWorkSheetFile(localization);
            

        }

        public bool getIsConnected()
        {
            return isConnected;
        }
        
        private bool setWorkSheetFile(String loc)
        {
            try
            {
                package = new ExcelPackage(new FileInfo(loc));
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public void setWorkSheetIndex(int i)
        {
            excelWorksheet = package.Workbook.Worksheets[i];
        }

        public String getWorkSheetIndex()
        {
            return excelWorksheet.Index.ToString();
               // return 0;
        }

        public String getWorkSheetIndexes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var i in package.Workbook.Worksheets)
            {
                stringBuilder.Append(i.Index + ", ");
            }

                return stringBuilder.ToString();

            // return 0;
        }

        public Dictionary<int, String> getWorkSheetIndexesAndNames()
        {
            Dictionary<int, String> dict = new Dictionary<int, string>();
           
            foreach (var i in package.Workbook.Worksheets)
            {
                dict.Add(i.Index, i.Name);
            }
            return dict;
        }


        public int getIndexByName(String name)
        {
            foreach (var i in package.Workbook.Worksheets)
            {
                if(i.Name == name)
                {
                    return i.Index;
                }
            }
            return 0;
        }

        public void sendData()
        {
            if (excelWorksheet != null)
            {
                excelWorksheet.Cells[1, 1].Value = "asd";
                package.Save();
            }
         
        }

        //public String getTypeOfColumn()
        //{

        //}






        public String getData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (excelWorksheet != null)
            {
               
                for (int row = 2; row <= excelWorksheet.Dimension.Rows; row++)
                {
                    stringBuilder.Append("( ");
                    for (int column = 1; column <= excelWorksheet.Dimension.Columns; column++)
                    {
                        var val = column < excelWorksheet.Dimension.Columns ? "'," : "'";
                        stringBuilder.Append("'" + excelWorksheet.Cells[row, column].Value + val);

                    }
                    var end = row < excelWorksheet.Dimension.Rows ? ")," : ")";
                    stringBuilder.Append(end);

                }
            }
            
            //var companyData = addr.Split(',');
            return stringBuilder.ToString();

        }


        public String getWorkSheetName()
        {
            excelWorksheet = package.Workbook.Worksheets[1];
            return excelWorksheet.Name;
        }

        public String getHeaders()
        {
            excelWorksheet = package.Workbook.Worksheets[1];
            StringBuilder stringBuilder = new StringBuilder();


            for (int column = 1; column <= excelWorksheet.Dimension.Columns; column++)
            {
                if(column!= excelWorksheet.Dimension.Columns) { 
                stringBuilder.Append(excelWorksheet.Cells[1, column].Value + ",");
                }
                else
                {
                    stringBuilder.Append(excelWorksheet.Cells[1, column].Value);
                }
            }

            

            //var companyData = addr.Split(',');
            return stringBuilder.ToString();
        }
    }
}
