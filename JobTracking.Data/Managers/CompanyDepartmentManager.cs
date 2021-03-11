using JobTracking.Core.Entities;
using JobTracking.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace JobTracking.Data.Managers
{
    public class CompanyDepartmentManager : BaseManager<CompanyDepartment, CompanyDepartmentRepository, MainDbContext>
    {
        public CompanyDepartmentManager(CompanyDepartmentRepository repository)
    : base(repository)
        {

        }
        public override async Task<CompanyDepartment> Update(CompanyDepartment entity)
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
        public override async Task<CompanyDepartment> Insert(CompanyDepartment entity)
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
