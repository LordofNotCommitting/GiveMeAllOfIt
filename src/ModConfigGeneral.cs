using MGSC;
using ModConfigMenu.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GiveMeAllOfIt
{
    // Token: 0x02000006 RID: 6
    public class ModConfigGeneral
    {

        // ====== combined ======
        // default, min, max value respectively
        public static int[] Exp_Flat_Perc_Array = new int[] { 65, -100, 100 };
        public static int[] Exp_DmgMult_Perc_Array = new int[] { 50, 0, 500 };

        public ModConfigGeneral(string ModName, string ConfigPath)
        {
            this.ModName = ModName;
            this.ModData = new ModConfigData(ConfigPath);
            this.ModData.AddConfigHeader("General Settings", "general");
            this.ModData.AddConfigValue("general", "Proxy_All_By_Default", false, "Proxy Select All by Default", "Select All items by default from station if proxy's station is selected.");
            this.ModData.AddConfigValue("general", "about_final", "<color=#f51b1b>The game must be restarted after setting then saving this config to take effect.</color>\n");
            this.ModData.RegisterModConfigData(ModName);
        }

        private string ModName;

        public ModConfigData ModData;

    }
}
