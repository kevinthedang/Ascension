using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Weapons
{
    public class AscendantsStaff : ModItem 
    {
        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.DD2_BookStaffCast;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.TopazBolt;
            Item.shootSpeed = 16f;
        }

        public override void SetStaticDefaults()
        {
            Item.staff[Item.type] = true;
        }

        // TODO: Remove when done testing
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}