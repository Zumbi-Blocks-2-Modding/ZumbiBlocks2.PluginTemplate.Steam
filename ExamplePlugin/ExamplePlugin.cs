using BepInEx;

namespace ExamplePlugin;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
public class ExamplePlugin : BaseUnityPlugin
{
    public const string PluginGUID = PluginAuthor + "." + PluginName;
    public const string PluginAuthor = "AuthorName";
    public const string PluginName = "ExamplePlugin";
    public const string PluginVersion = "0.1.0";

    private void Awake()
    {
        Logger.LogInfo($"Initialized plugin: {PluginName} ({PluginGUID}@{PluginVersion})");
        Logger.LogInfo($"Current Zumbi Blocks 2 version is {ZBMain.instance.gameVersion}");
    }
}
