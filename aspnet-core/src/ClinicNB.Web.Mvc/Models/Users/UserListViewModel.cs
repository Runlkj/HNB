using System.Collections.Generic;
using ClinicNB.Roles.Dto;

namespace ClinicNB.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
