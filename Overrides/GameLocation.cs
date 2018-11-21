﻿using StardewValley;
using StardewValley.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGeodes.Overrides
{
    public static class MonsterDamageHook
    {
        public static bool Prefix(GameLocation __instance, Microsoft.Xna.Framework.Rectangle areaOfEffect,ref int minDamage, ref int maxDamage, bool isBomb, float knockBackModifier, int addedPrecision, float critChance, float critMultiplier, bool triggerMonsterInvincibleTimer, Farmer who)
        {
            double mult = 1.0 + who.HasAdornment(ToolType.Weapon, Mod.Config.GEODE_MORE_DAMAGE) * 0.20;
            minDamage = (int)(minDamage * mult);
            maxDamage = (int)(maxDamage * mult);
            return true;
        }
    }
}
