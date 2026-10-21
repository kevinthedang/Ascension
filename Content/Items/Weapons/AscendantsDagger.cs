using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Ascension.Content.Projectiles;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsDagger : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Generic; // Standalone version, not Calamity Rogue
            Item.knockBack = 1f;

            Item.width = 26;
            Item.height = 26;

            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.noUseGraphic = true;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.noMelee = true;

            Item.shoot = ModContent.ProjectileType<AscendantsDaggerProjectile>();
            Item.shootSpeed = 15f;

            Item.rare = ItemRarityID.Cyan;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, 0f);
        }
    }
}
