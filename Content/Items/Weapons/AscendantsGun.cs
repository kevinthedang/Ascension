using Ascension.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsGun : GenericAimedWeapon
    {
        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.DamageType = DamageClass.Ranged;

            Item.width = 36;
            Item.height = 22;

            Item.useTime = 26;
            Item.useAnimation = 26;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.channel = true;
            
            Item.knockBack = 5f;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.Bullet; // TODO: custom projectile?
            Item.shootSpeed = 16f;

            Item.rare = ItemRarityID.Cyan;
        }

        /// <summary>
        /// Makes sure the player can only have one bullet projectile active at a time. This prevents spamming bullets and makes the gun feel more balanced.
        /// </summary>
        /// <param name="player">the player which we check if they can use the item</param>
        /// <returns>true if the item can be used, false otherwise</returns>
        // public override bool CanUseItem(Player player)
        // {
        //     return !Main.projectile.Any(n => n.active && n.owner == player.whoAmI && n.type == ProjectileID.Bullet);
        // }
    }
}