using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
    public class TinyLight : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Illustris");
            Tooltip.SetDefault("'Light'");
        }

        public override void SetDefaults()
        {
            item.damage = 26;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 26;
            item.useAnimation = 13;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.scale = 1f;
            item.shoot = mod.ProjectileType("TinyLightProjectile");
            item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(ItemID.CrystalShard, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}