using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
    public class GrandSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Libra");
            Tooltip.SetDefault("'Balance'");
        }

        public override void SetDefaults()
        {
            item.damage = 142;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.scale = 1f;
            item.shoot = mod.ProjectileType("GrandSwordProjectile");
            item.shootSpeed = 18f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TinyLight"), 1);
            recipe.AddIngredient(mod.ItemType("TinyDark"), 1);
            recipe.AddIngredient(mod.ItemType("TinyBlood"), 1);
            recipe.AddIngredient(mod.ItemType("GolemShard"), 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}