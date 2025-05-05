using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using UnityEngine;

namespace TunicRunInBackground
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static new ManualLogSource Log;

        public override void Load()
        {
            Log = base.Log;
            Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            Application.runInBackground = true;
        }
    }
}