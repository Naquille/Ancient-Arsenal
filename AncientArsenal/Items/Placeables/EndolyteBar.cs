using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Placeables
{
    public class EndolyteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endolyte Bar");
            Tooltip.SetDefault("Scorching to the touch");
            ItemID.Sets.SortingPriorityMaterials[item.type] = 61; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 99;
            item.value = 7500;
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("EndolyteBarTile");
            item.placeStyle = 0;
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteOreItem"), 4);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
