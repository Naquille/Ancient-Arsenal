using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Weapons
{
	public class IceTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Needle");
			Tooltip.SetDefault("Casts a burst of sharp ice shards");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.magic = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 20000;
			item.rare = 3;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.scale = 0.91f;
			item.shoot = ProjectileID.Blizzard;
			item.shootSpeed = 14f;
			item.noMelee = true;
			item.mana = 5;
            item.crit = 12;
		}
		
			public override Vector2? HoldoutOffset()
		{
			return new Vector2(4, 4);
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            return true;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Snowball, 70);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.Sapphire, 5);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
