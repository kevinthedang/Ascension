using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Ascension.Content.Projectiles;
using Ascension.Content.DamageClasses;
using Ascension.Content.Rarities;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsDagger : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 25;
            Item.DamageType = RogueDamageClass.Instance;
            Item.knockBack = 1f;

            Item.width = 26;
            Item.height = 26;

            Item.useTime = 22;
            Item.useAnimation = 22;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.noUseGraphic = true;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.noMelee = true;

            Item.shoot = ModContent.ProjectileType<AscendantsDaggerProjectile>();
            Item.shootSpeed = 15f;

            Item.rare = ModContent.RarityType<NoviceRarity>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, 0f);
        }
    }
}
