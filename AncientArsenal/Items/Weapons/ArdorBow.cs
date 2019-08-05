using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items.Weapons
{
    public class ArdorBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ardor Bow");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 26;
            item.height = 58;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 8;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Arrow;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.HellfireArrow; // or ProjectileID.FireArrow;
            }

            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(5);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 14);
            recipe.AddIngredient(ItemID.FlaskofFire, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}