using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Placeables
{
    public class PurathylBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purathyl Bar");
            ItemID.Sets.SortingPriorityMaterials[item.type] = 60; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
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
            item.createTile = mod.TileType("PurathylBarTile");
            item.placeStyle = 0;
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 5);
            recipe.AddIngredient(ItemID.PurificationPowder, 1);
            recipe.AddIngredient(ItemID.Bone, 4);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this,5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe.AddIngredient(ItemID.PurificationPowder, 1);
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this,5);
            recipe.AddRecipe();
        }
        
    }
}
