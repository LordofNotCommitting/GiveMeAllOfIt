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
    [HarmonyPatch(typeof(StationTradeItemPanel), nameof(StationTradeItemPanel.IncreaseButtonOnClick))]
    public static class ExamplePatch
    {
        public static void Prefix(StationTradeItemPanel __instance, CommonButton arg1, int arg2)
        {
            //Plugin.Logger.Log("--- main menu awake");

            __instance.TradeCount = Mathf.Clamp(__instance.TradeCount + 10000, 0, __instance.ItemsCount);
        }

    }
}
