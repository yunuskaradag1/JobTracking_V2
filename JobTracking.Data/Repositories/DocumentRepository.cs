using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
   public class DocumentRepository : BaseMainRepository<Document>
    {
        public DocumentRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
