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
    [HarmonyPatch(typeof(StationExchangePage), nameof(StationExchangePage.Initialize))]
    public static class StationExchangePage_Awake_Prefix
    {
        public static bool is_proxy = false;
        public static void Postfix(StationExchangePage __instance)
        {
            ProxyCorpDepartment department = __instance._magnumProgression.GetDepartment<ProxyCorpDepartment>();
            Faction faction = __instance._factions.Get(__instance._station.OwnerFactionId, true);
            is_proxy = (department.ProxyFactionId == faction.Id);

        }

    }
}
