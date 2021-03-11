using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
  public  class NoteRepository : BaseMainRepository<Note>
    {
        public NoteRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
