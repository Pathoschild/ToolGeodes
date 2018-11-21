﻿using StardewValley;
using StardewValley.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGeodes.Overrides
{
    public static class AxeStaminaHook
    {
        public static void Prefix(Axe __instance, GameLocation location, int x, int y, int power, Farmer who)
        {
            who.Stamina += Math.Min(who.HasAdornment(ToolType.Axe, Mod.Config.GEODE_LESS_STAMINA), 4) * 0.25f;

        }
    }
}
