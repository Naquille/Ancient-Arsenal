using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Tools
{
    public class ThermiaPick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thermia Pickaxe");
            Tooltip.SetDefault("Can mine Mythril and Orichalcum");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 12;
            item.useAnimation = 17;
            item.pick = 205;
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
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}