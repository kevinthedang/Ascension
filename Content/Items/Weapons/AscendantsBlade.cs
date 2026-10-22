using Ascension.Content.Rarities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Weapons
{   
    // https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    public class AscendantsBlade : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.Ascension.hjson' file.
        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.DamageType = DamageClass.Melee;

            Item.width = 40;
            Item.height = 40;

            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Swing;

            Item.knockBack = 5;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;

            Item.rare = ModContent.RarityType<NoviceRarity>();
        }
    }
}
