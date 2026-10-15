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
        /// Smooths out holding the gun
        /// </summary>
        /// <param name="player">the player</param>
        public override void UseItemFrame(Player player) 
        {
            // Calculate the angle between the player and the mouse cursor
            Vector2 direction = Main.MouseWorld - player.MountedCenter;
            float rotation = direction.ToRotation();

            // Assign the angle to the item's rotation
            player.itemRotation = rotation;

            // Ensure the player flips correctly depending on where they point
            player.direction = (Main.MouseWorld.X < player.MountedCenter.X) ? -1 : 1;

            // Adjust the sprite rotation if it appears upside down when facing left
            if (player.direction == -1) {
                player.itemRotation += MathHelper.Pi; // Flips the sprite 180 degrees
            }
        }
    }
}