using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
	public class OvergrownBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silvana");
			Tooltip.SetDefault("'It lives'");
		}
		
		public override void SetDefaults()
		{
			item.damage = 22;
			item.melee = true;
			item.width = 48;
			item.height = 50;
			item.useTime = 32;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1.15f;
			item.shoot = ProjectileID.Leaf;
			item.shootSpeed =16f;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            base.OnHitNPC(player, target, damage, knockBack, crit);
            target.AddBuff(BuffID.Poisoned, 360);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            type = Main.rand.Next(new int[] { type, 227 });
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrassSeeds, 20);
			recipe.AddIngredient(mod,"OldSword", 1);
			recipe.AddIngredient(mod,"PurathylBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	
	}
}
