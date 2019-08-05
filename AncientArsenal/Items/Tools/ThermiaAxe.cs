
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Tools
{
    public class ThermiaAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thermia Axe");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 42;
            item.height = 38;
            item.useTime = 14;
            item.useAnimation = 19;
            item.axe = 24;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 75000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}