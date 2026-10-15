using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Utilities
{
    public abstract class GenericAimedWeapon : ModItem
    {
        // TODO: Remove when done testing
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        /// <summary>
        /// Smooths out holding the gun aligning player arm
        /// </summary>
        /// <param name="player">the player</param>
        /// <param name="heldItemFrame">the frame of the held item</param> 
        public override void UseStyle(Player player, Rectangle heldItemFrame) 
        {
            Vector2 direction = Main.MouseWorld - player.MountedCenter;
            player.direction = (Main.MouseWorld.X < player.MountedCenter.X) ? -1 : 1;
            float rotation = direction.ToRotation();

            if (player.direction == -1)
                rotation += MathHelper.Pi; // Flips the sprite 180 degrees
            player.itemRotation = MathHelper.WrapAngle(rotation);
        }
    }
}