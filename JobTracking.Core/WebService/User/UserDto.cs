using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gsm { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? TownId { get; set; }
        public string PostCode { get; set; }
        public string Adress { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
        public int? Score { get; set; }
        public bool IsActive { get; set; }
        public bool? IsLogin { get; set; }
        public bool IsPasswordChange { get; set; }
        public int DepartmentId { get; set; }
        public int? ResponsibleUserId { get; set; }
        public DateTime? FirstLoginDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LoginTime { get; set; }
        public int? AvatarId { get; set; }
        public bool IsDeleted { get; set; }
        public int? StartPageId { get; set; }
    }
}
