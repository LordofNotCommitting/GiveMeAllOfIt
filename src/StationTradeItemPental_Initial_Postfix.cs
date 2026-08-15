using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GiveMeAllOfIt
{
    [HarmonyPatch(typeof(StationTradeItemPanel), nameof(StationTradeItemPanel.Initialize))]
    public static class StationTradeItemPental_Initial_Postfix
    {

        static bool Proxy_All_By_Default = Plugin.ConfigGeneral.ModData.GetConfigValue<bool>("Proxy_All_By_Default", false);
        public static void Postfix(string itemId, int count, int price, int tradeCount, bool tradingAvailable, StationTradeItemPanel __instance)
        {
            //Plugin.Logger.Log("--- main menu awake");
            if (Proxy_All_By_Default && StationExchangePage_Awake_Prefix.is_proxy)
            {
                //Plugin.Logger.Log("WHYYY");
                __instance.TradeCount = __instance.ItemsCount;
                __instance.RefreshTradeValue();
                __instance._tradeBlock.SetActive(true);
                Traverse.Create(__instance).Field<Action<StationTradeItemPanel>>("TradeValueChanged").Value?.Invoke(__instance);
            }
        }

    }
}
