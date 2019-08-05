using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
	public class OldSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flora Sword");
			Tooltip.SetDefault("'Humble beginnings'");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 38;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1.15f;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            base.OnHitNPC(player, target, damage, knockBack, crit);
            target.AddBuff(BuffID.Poisoned, 360);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrassSeeds, 10);
			recipe.AddIngredient(ItemID.CopperBroadsword, 1);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
