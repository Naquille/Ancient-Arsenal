using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
    public class Tamere : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cataegis");
            Tooltip.SetDefault("'Beautiful Chaos'");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.ranged = true;
            item.width = 26;
            item.height = 58;
            item.useTime = 4;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 8;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = 1; 
            item.shootSpeed = 18f;
            item.useAmmo = AmmoID.Arrow;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
            speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;

            type = Main.rand.Next(new int[] { type, ProjectileID.FireArrow, ProjectileID.HellfireArrow, ProjectileID.CursedArrow, ProjectileID.FrostburnArrow, ProjectileID.IchorArrow, ProjectileID.ShadowFlameArrow });
			return true;
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShadowFlameBow, 1);
            recipe.AddIngredient(ItemID.IceBow, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.HellwingBow, 1);
            recipe.AddIngredient(ItemID.CursedFlame, 20);
            recipe.AddIngredient(ItemID.Ichor, 20);
            recipe.AddIngredient(mod.ItemType("GolemShard"), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}