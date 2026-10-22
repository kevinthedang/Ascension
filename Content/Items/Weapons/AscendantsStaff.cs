using Ascension.Content.Rarities;
using Ascension.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsStaff : GenericAimedWeapon 
    {
        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;

            Item.useTime = 35;
            Item.useAnimation = 35;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item43;

            Item.knockBack = 6;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.SapphireBolt;
            Item.shootSpeed = 16f;

            Item.rare = ModContent.RarityType<NoviceRarity>();
        }

        public override bool Shoot(
            Player player,
            EntitySource_ItemUse_WithAmmo source,
            Vector2 position,
            Vector2 velocity,
            int type,
            int damage,
            float knockback)
        {
            Vector2 leftVelocity = velocity.RotatedBy(MathHelper.ToRadians(-3f));
            Vector2 rightVelocity = velocity.RotatedBy(MathHelper.ToRadians(3f));

            Projectile.NewProjectile(
                source, position, leftVelocity, type, damage, knockback, player.whoAmI);

            Projectile.NewProjectile(
                source, position, rightVelocity, type, damage, knockback, player.whoAmI);

            return false;
        }

        public override void SetStaticDefaults()
        {
            Item.staff[Item.type] = true;
        }
    }
}