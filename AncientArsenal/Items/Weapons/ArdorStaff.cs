using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Weapons
{
    public class ArdorStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ardor Staff");
            Tooltip.SetDefault("'Hellfire!'");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.damage = 16;
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
            item.mana = 16;
            item.crit = 5;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            Vector2 target = Main.screenPosition + new Vector2(((float)Main.mouseX + Main.rand.Next(-100, 100)), (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 2; i++)
            {
                position = Main.screenPosition + new Vector2(((float)Main.rand.Next(-200, 200) + Main.mouseX), -600f - (i * 100));
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-30, 30) * 0.02f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, ceilingLimit);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 18);
            recipe.AddIngredient(ItemID.FlaskofFire, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}