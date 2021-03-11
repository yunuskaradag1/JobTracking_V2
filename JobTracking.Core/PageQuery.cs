using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class PageQuery
    {
        public string OrderColumn { get; set; }
        public string OrderDir { get; set; }
        public short PageNumber { get; set; }
        public short PageSize { get; set; }
        public List<QueryParameter> Parameters { get; set; }
    }
}
