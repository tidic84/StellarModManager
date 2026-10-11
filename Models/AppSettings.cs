using System.Collections.Generic;
using System.Globalization;

namespace StellarModManager.Models;

public class AppSettings
{
    public string Language { get; set; } = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
    public bool ConfirmBeforeRemove { get; set; } = true;
    public bool AutoCheckForModUpdates { get; set; } = true;
    public bool AutoCheckForAppUpdates { get; set; } = true;
    public string Theme { get; set; } = Services.ThemeService.DefaultThemeName;
    public int ModSort { get; set; }
    public bool CompactModList { get; set; }
    // Extra mods.json sources listed alongside the official repository
    // TF edition: the friends' repository is there on first launch, it can still be removed
    public List<string> CustomRepositories { get; set; } = new() { "https://raw.githubusercontent.com/tidic84/StellarModRepository/main/mods.json" };
}