﻿using StardewValley;
using StardewValley.Tools;

namespace ToolGeodes.Overrides
{
    class MeleeWeaponSpeedHook
    {
        public static void Prefix(MeleeWeapon __instance, Farmer who)
        {
            if (who.HasAdornment(ToolType.Weapon, Mod.Config.GEODE_SWIPE_SPEED) > 0)
                who.weaponSpeedModifier += 0.5f;
        }

        public static void Postfix(MeleeWeapon __instance, Farmer who)
        {
            if (who.HasAdornment(ToolType.Weapon, Mod.Config.GEODE_SWIPE_SPEED) > 0)
                who.weaponSpeedModifier -= 0.5f;
        }
    }
}
