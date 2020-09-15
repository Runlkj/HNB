using System.Collections.Generic;
using ClinicNB.Roles.Dto;

namespace ClinicNB.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}