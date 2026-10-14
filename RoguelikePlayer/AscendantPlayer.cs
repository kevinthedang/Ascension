using Terraria;
using Terraria.ModLoader;

namespace Ascension.RoguelikePlayer
{
    public class AscendantPlayer : ModPlayer
    {
        public override void ResetEffects()
        {
            // Set Crit to 1%
            Player.GetCritChance(DamageClass.Generic) -= 3f;
        }
    }
}