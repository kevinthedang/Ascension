using Terraria;
using Ascension.AscPLayer;

namespace Ascension.Utilities
{
    public static partial class AscensionUtils
    {
        /// <summary>
        /// Simply GetModPlayer Call
        /// </summary>
        /// <param name="player">the player</param>
        /// <returns>the mod player</returns>
        public static AscensionPlayer ModPlayer(this Player player)
        {
            return player.GetModPlayer<AscensionPlayer>();
        }
    }
}