using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Weapons
{
    public class ArdorBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ardor Blade");
            Tooltip.SetDefault("'Feel the heat!'");
        }

        public override void SetDefaults()
        {
            item.damage = 39;
            item.melee = true;
            item.width = 40;
            item.height = 46;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 750000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.scale = 1f;
            item.shoot = 668;
            item.shootSpeed = 12f;
            item.crit = 8;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            type = Main.rand.Next(new int[] { type, 668, 664, 666 });
            return true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 180);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 16);
            recipe.AddIngredient(ItemID.FlaskofFire, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}