using System.Collections.Generic;
using ClinicNB.Roles.Dto;

namespace ClinicNB.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
