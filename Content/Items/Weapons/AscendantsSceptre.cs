using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsSceptre : ModItem
    {
        public override void SetStaticDefaults()
        {
            // One minion slot, like the Finch Staff.
            ItemID.Sets.StaffMinionSlotsRequired[Type] = 1f;
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Summon;
            Item.knockBack = 4f;

            Item.width = 32;
            Item.height = 32;

            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item44;
            Item.autoReuse = true;
            Item.noMelee = true;

            Item.shoot = ProjectileID.BabyBird;
            Item.shootSpeed = 10f;
            Item.buffType = BuffID.BabyBird;

            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(gold: 1);
        }

        public override bool Shoot(
            Player player,
            Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source,
            Vector2 position,
            Vector2 velocity,
            int type,
            int damage,
            float knockback)
        {
            // Keep the Baby Finch buff active while the minion is summoned.
            player.AddBuff(Item.buffType, 2);

            // Finch Staff-style: summon at the cursor rather than firing a moving projectile.
            Projectile.NewProjectile(
                source,
                Main.MouseWorld,
                Vector2.Zero,
                type,
                damage,
                knockback,
                player.whoAmI
            );

            // We created the projectile ourselves.
            return false;
        }
    }
}
