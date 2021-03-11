using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
  public  class UserDocumentRepository : BaseMainRepository<UserDocument>
    {
        public UserDocumentRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
