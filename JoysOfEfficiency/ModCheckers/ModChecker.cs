﻿using StardewModdingAPI;

namespace JoysOfEfficiency.ModCheckers
{
    public class ModChecker
    {
        public static bool IsCJBCheatsLoaded(IModHelper helper)
        {
            return helper.ModRegistry.IsLoaded("CJBok.CheatsMenu");
        }
    }
}