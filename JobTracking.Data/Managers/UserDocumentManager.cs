﻿using JobTracking.Core.Entities;
using JobTracking.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace JobTracking.Data.Managers
{
  public  class UserDocumentManager : BaseManager<UserDocument, UserDocumentRepository, MainDbContext>
    {
        public UserDocumentManager(UserDocumentRepository repository)
    : base(repository)
        {

        }
        public override async Task<UserDocument> Update(UserDocument entity)
        {
            using (var transaction = repository.Context.Database.BeginTransaction())
            {
                try
                {
                    await base.Update(entity);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return entity;
        }
        public override async Task<UserDocument> Insert(UserDocument entity)
        {
            using (var transaction = repository.Context.Database.BeginTransaction())
            {
                try
                {
                    await base.Insert(entity);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return entity;
        }
    }
}
