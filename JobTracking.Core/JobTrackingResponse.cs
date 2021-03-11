using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
   public class JobTrackingResponse
    {
        public short ResponseType { get; set; }

        public string Message { get; set; }

        public JobTrackingResponse(ResponseType response, string msg = "")
        {
            ResponseType = (short)response;
            Message = msg;
        }

        public virtual object GetItem()
        {
            return null;
        }
    }
    public class JobTrackingResponse<T> : JobTrackingResponse
    {
        public JobTrackingResponse(T t, ResponseType response, string msg = "") : base(response, msg)
        {
            Item = t;
        }

        public T Item { get; set; }

        public override object GetItem()
        {
            return Item;
        }
    }
}

