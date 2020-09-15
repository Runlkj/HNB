﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ClinicNB.Configuration.Dto;

namespace ClinicNB.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ClinicNBAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
