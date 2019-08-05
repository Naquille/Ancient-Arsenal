using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Projectiles
{
    class GrandSwordProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Beam");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 24;
            projectile.timeLeft = 120;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.melee = true;
            projectile.aiStyle = 207;
            projectile.penetrate = 1;
            projectile.light = 0.25f;
            projectile.scale = 0.75f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            base.OnHitNPC(target, damage, knockback, crit);
            target.AddBuff(BuffID.Ichor, 360);
            target.AddBuff(BuffID.CursedInferno, 360);
            // This code spawns 3 projectiles in the opposite direction of the projectile, with random variance in velocity.
            if (projectile.owner == Main.myPlayer)
            {
                for (int i = 0; i < 4; i++)
                {
                    // Calculate new speeds for other projectiles.
                    // Rebound at 40% to 70% speed, plus a random amount between -8 and 8
                    float speedX = projectile.velocity.X * Main.rand.NextFloat(.4f, .7f) + Main.rand.NextFloat(-2f, 2f);
                    float speedY = projectile.velocity.Y * Main.rand.Next(40, 70) * 0.01f + Main.rand.Next(-15, 16) * 0.4f; // This is Vanilla code, a little more obscure.
                                                                                                                             // Spawn the Projectile.
                    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, speedX, speedY, mod.ProjectileType("MicroGrandProjectile"), (int)(projectile.damage * 0.4), 0f, projectile.owner, 0f, 0f);
                }
            }

        }
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(45f);
            Vector2 randVect = new Vector2(Main.rand.Next(-15, 15), Main.rand.Next(-15, 15));
            int dustnumber = Dust.NewDust(projectile.position + randVect, projectile.width, projectile.height, 169, 0f, 0f, 100, default(Color), 1.2f);
            Main.dust[dustnumber].velocity = projectile.velocity * 0.5f;
            Main.dust[dustnumber].noGravity = true;
        }
    }
}