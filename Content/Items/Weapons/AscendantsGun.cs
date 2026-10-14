using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsGun : ModItem
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
            Item.rare = ItemRarityID.Cyan;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.Bullet; // TODO: custom sound?
            Item.shootSpeed = 16f;
        }

        // TODO: Remove when done testing
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        /// <summary>
        /// Makes sure the player can only have one bullet projectile active at a time. This prevents spamming bullets and makes the gun feel more balanced.
        /// </summary>
        /// <param name="player">the player which we check if they can use the item</param>
        /// <returns>true if the item can be used, false otherwise</returns>
        public override bool CanUseItem(Player player)
        {
            return !Main.projectile.Any(n => n.active && n.owner == player.whoAmI && n.type == ProjectileID.Bullet);
        }
    }
}