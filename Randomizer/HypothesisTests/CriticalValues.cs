using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Randomizer.HypothesisTests
{
    public static class CriticalValues
    {
        private static Dictionary<int, Dictionary<double, double>> ChiSquareCriticalValues;

        public static double GetCriticalValue(int libertyGrade, double percentile)
        {
            Dictionary<double, double> libertyGradeValues;
            double result = 0;

            if (CriticalValues.ChiSquareCriticalValues == null)
            {
                InitChiSquareCriticalValues();
            }

            if (ChiSquareCriticalValues.TryGetValue(libertyGrade, out libertyGradeValues))
            {
                libertyGradeValues.TryGetValue(percentile, out result);
            }

            return result;
        }

        public static IEnumerable<double> GetSignificantValues()
        {
            var significantValue = new List<double>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string path = ConfigurationManager.AppSettings.Get("ExcelPath");
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

            int columns = worksheet.Dimension.Columns;

            for (int i = 2; i < columns; i++)
            {
                significantValue.Add(Convert.ToDouble(worksheet.Cells[1, i].Value.ToString()));
            }

            return significantValue;
        }

        private static void InitChiSquareCriticalValues()
        {
            ChiSquareCriticalValues = new Dictionary<int, Dictionary<double, double>>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string path = ConfigurationManager.AppSettings.Get("ExcelPath");
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

            int rows = worksheet.Dimension.Rows;
            int columns = worksheet.Dimension.Columns;

            for (int i = 2; i < rows; i++)
            {
                var libertyGrade = new Dictionary<double, double>();

                for (int j = 2; j < columns; j++)
                {
                    libertyGrade.Add(Convert.ToDouble(worksheet.Cells[1, j].Value.ToString()), Convert.ToDouble(worksheet.Cells[i, j].Value.ToString()));
                }

                ChiSquareCriticalValues.Add(Convert.ToInt32(worksheet.Cells[i, 1].Value.ToString()), libertyGrade);
            }
        }
    }
}
