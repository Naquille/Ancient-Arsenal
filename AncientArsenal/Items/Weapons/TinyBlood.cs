using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
    public class TinyBlood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanguis");
            Tooltip.SetDefault("'Blood'");
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
            item.shoot = mod.ProjectileType("TinyBloodProjectile");
            item.shootSpeed = 16f;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            base.OnHitNPC(player, target, damage, knockBack, crit);
            target.AddBuff(BuffID.Ichor, 360);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.Ichor, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}