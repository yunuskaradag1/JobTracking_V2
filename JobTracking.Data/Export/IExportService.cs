using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Export
{
    public interface IExportService
    {
        byte[] ExportToXlsx<T>(List<T> data, string tableName = null) where T : class;
       
    }
}
