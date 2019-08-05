using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Projectiles
{
    class TinyBloodProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Shard");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 28;
            projectile.height = 28;
            projectile.timeLeft = 120;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.melee = true;
            projectile.aiStyle = 207;
            projectile.penetrate = 3;
            projectile.light = 0.25f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            base.OnHitNPC(target, damage, knockback, crit);
            target.AddBuff(BuffID.Ichor, 360);
        }
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(45f);
            Vector2 randVect = new Vector2(Main.rand.Next(-15, 15), Main.rand.Next(-15, 15));
            int dustnumber = Dust.NewDust(projectile.position + randVect, projectile.width, projectile.height, 127, 0f, 0f, 100, default(Color), 1.2f);
            Main.dust[dustnumber].velocity = projectile.velocity * 0.5f;
            Main.dust[dustnumber].noGravity = true;
        }
    }
}