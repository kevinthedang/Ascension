using Terraria;
using Terraria.ModLoader;

namespace Ascension.AscPLayer
{
    public class AscensionPlayer : ModPlayer
    {
        public override void ResetEffects()
        {
            // Set Crit to 1%
            Player.GetCritChance(DamageClass.Generic) -= 3f;
        }
    }
}