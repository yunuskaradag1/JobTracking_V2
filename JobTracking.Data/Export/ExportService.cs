using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace JobTracking.Data.Export
{
    public class ExportService 
    {
        private readonly ResourceManager _resourceManager;

        //public ExportService(CurrentUser currentUser, ResourceManager resourceManager)
        //{
        //    _resourceManager = resourceManager;
        //}

        //public byte[] ExportToXlsx<T>(List<T> data, string tableName = null) where T : class
        //{
        //    Type type = typeof(T);
        //    if (tableName == null)
        //    {
        //        tableName = type.Name;
        //    }

        //    var obj = (T)Activator.CreateInstance(typeof(T));
        //    Type targetmodeltype = obj.GetType();
        //    PropertyInfo[] props = targetmodeltype.GetProperties();
        //    var properties = new List<ExcelPropertyDto>();
        //    for (int i = 0; i < props.Count(); i++)
        //    {
        //        var p = PropertyHelper.GetDescription<T>(props[i].Name);
        //        if (p != null)
        //        {
        //            //var r = resource.Find(f => f.Key == p && f.Lang == _currentUser.Lang);
        //            var r = _resourceManager.Translate(p);
        //            properties.Add(new ExcelPropertyDto
        //            {
        //                Property = props[i],
        //                Description = r == null ? p : r,
        //                IsHasDescription = p == null ? false : true,
        //                Index = i,
        //            });
        //        }

        //    }

        //    properties = properties.Where(t => t.IsHasDescription).ToList();
        //    byte[] result = null;
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (ExcelPackage package = new ExcelPackage())
        //    {

        //        var worksheet = package.Workbook.Worksheets.Add(tableName);
        //        using (var cells = worksheet.Cells[1, 1, 1, properties.Count()])
        //        {
        //            cells.Style.Font.Bold = true;
        //            cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
        //            cells.Style.Fill.BackgroundColor.SetColor(Color.Gray);
        //            cells.Style.Font.Color.SetColor(Color.White);
        //        }

        //        var columns = new List<string>();

        //        properties.ForEach(x =>
        //        {
        //            var attribute = x.Description;

        //            columns.Add(attribute);
        //        });

        //        for (int i = 0; i < columns.Count(); i++)
        //        {
        //            worksheet.Cells[1, i + 1].Value = columns[i];
        //        }

        //        //Listten gelen dataları excele dolduruyoruz
        //        var j = 2;
        //        var count = 1;
        //        var row = 1;

        //        foreach (var item in data)
        //        {

        //            row++;

        //            var cell = 0;

        //            properties.ForEach(x =>
        //            {
        //                cell++;
        //                var obj = x.Property.GetValue(item, null);
        //                if (obj != null)
        //                {
        //                    worksheet.Cells[row, cell].Value = obj.ToString();
        //                }

        //            });

        //            j++;
        //            count++;
        //        }

        //        //Kolonları datalara göre otomatik genişletiyoruz
        //        worksheet.Cells.AutoFitColumns();

        //        result = package.GetAsByteArray();
        //    }

        //    return result;
        //}

    }
}
