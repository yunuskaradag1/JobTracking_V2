using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
  public  class CompanyUserDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Gsm { get; set; }
        public int CompanyId { get; set; }
        public int CompanyDepartmentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
