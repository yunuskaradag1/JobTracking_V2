using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class JobTrackingDataSource<T>
    {
        public List<T> Items { get; set; }

        public int Count { get; set; }
    }
   }
