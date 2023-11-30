using NPOI.XSSF.UserModel;

namespace Web.Api.Helpers
{
    public static class ExcelHelper
    {
        public static byte[] CreateFile<T>(List<T> source)
        {
            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("Sheet1");
            var rowHeader = sheet.CreateRow(0);

            var properties = typeof(T).GetProperties();

            //header
            var font = workbook.CreateFont();
            // font. = true;
            var style = workbook.CreateCellStyle();
            style.SetFont(font);

            var colIndex = 0;

            foreach (var item in properties)
            {
                var cell = rowHeader.CreateCell(colIndex);
                cell.SetCellValue(item.Name);
                cell.CellStyle = style;
                colIndex++;
            }
            //end header

            //content
                var rowNum = 1;
                foreach (var createRow in source)
                {
                    var rowContent = sheet.CreateRow(rowNum);

                    var colContentIndex = 0;
                    foreach (var propertyHeader in properties)
                    {
                        var cellContent = rowContent.CreateCell(colContentIndex);
                        var value = propertyHeader.GetValue(createRow, null);
                    if (value == null)
                    {
                        cellContent.SetCellValue("");
                    }
                    else if (propertyHeader.PropertyType == typeof(string))
                    {
                        cellContent.SetCellValue(value.ToString());
                    }
                    else if (propertyHeader.PropertyType == typeof(int) || propertyHeader.PropertyType == typeof(int?))
                    {
                        cellContent.SetCellValue(Convert.ToInt32(value));
                    }
                    else if (propertyHeader.PropertyType == typeof(decimal) || propertyHeader.PropertyType == typeof(decimal?))
                    {
                        cellContent.SetCellValue(Convert.ToDouble(value));
                    }
                    else if (propertyHeader.PropertyType == typeof(DateTime) || propertyHeader.PropertyType == typeof(DateTime?))
                    {
                        var dateValue = (DateTime)value;
                        cellContent.SetCellValue(dateValue.ToString("yyyy-MM-dd"));
                    }
                    else cellContent.SetCellValue(value.ToString());

                    colContentIndex++;
                }
                rowNum++;
            }
            //end content

            var stream = new MemoryStream();
            workbook.Write(stream);
            var content = stream.ToArray();

            return content;
        }
    }
}