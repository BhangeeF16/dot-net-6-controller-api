﻿using Microsoft.Extensions.Configuration;

namespace Domain.Common.Utilities;

public static class AppSettingsHelper
{
    public static string GetConnectionString(this IConfiguration configuration)
    {
        return configuration.GetSetting("SQLSERVER_GIGPANEL", "ConnectionStrings");
    }
    private static string GetSetting(this IConfiguration config, string Key, string Section = "")
    {
        var colonSpaceHolder = Section != null || Section != string.Empty ? ":" : string.Empty;
        return config[$"{Section}{colonSpaceHolder}{Key}"];
    }
}
