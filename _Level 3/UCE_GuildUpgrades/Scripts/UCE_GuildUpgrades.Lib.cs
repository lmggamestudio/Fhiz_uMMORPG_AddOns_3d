// =======================================================================================
// Created and maintained by iMMO
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: https://discord.gg/YkMbDHs
// * Public downloads website...........: https://www.indie-mmo.net
// * Pledge on Patreon for VIP AddOns...: https://www.patreon.com/IndieMMO
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public partial class UCE_DefinesManager
{

    [DevExtMethods("Constructor")]
    public static void Constructor_UCE_GuildUpgrades()
    {
         UCE_AddOn addon = new UCE_AddOn();

        addon.name          = "UCE GuildUpgrades";
        addon.basis         = "uMMORPG3d V1";
        addon.define        = "_iMMOGUILDUPGRADES";
        addon.author        = "Fhiz";
        addon.version       = "2019.202";
        addon.dependencies  = "UCE Guild Warehouse";
        addon.comments      = "none";
        addon.active        = true;

        addons.Add(addon);
    }

}

#endif
