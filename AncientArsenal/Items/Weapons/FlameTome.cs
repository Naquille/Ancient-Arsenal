using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Weapons
{
	public class FlameTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blaze");
			Tooltip.SetDefault("Casts a spray of burning embers");
		}
		public override void SetDefaults()
		{
			item.damage = 14;
			item.magic = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 40000;
			item.rare = 3;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.scale = 0.91f;
			item.shoot = ProjectileID.MolotovFire;
			item.shootSpeed = 14f;
			item.noMelee = true;
			item.mana = 10;
            item.crit = 5;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            return true;
        }


        public override Vector2? HoldoutOffset()
		{
			return new Vector2(4, 4);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.Ruby, 5);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 10);
            recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
