using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Placeables
{
    public class EndolyteOreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endolyte Ore");
            ItemID.Sets.SortingPriorityMaterials[item.type] = 60; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.value = 1500;
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("EndolyteOreTile");
            item.placeStyle = 0;
            item.rare = 3;
        }
    }
}
