using Terraria.ModLoader;

namespace Ascension.Content.DamageClasses
{
    public class RogueDamageClass : DamageClass
    {
        internal static RogueDamageClass Instance;
        public override void Load() => Instance = this;
        public override void Unload() => Instance = null;

        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            return damageClass == Generic ? StatInheritanceData.Full : StatInheritanceData.None;
        }
    }
}