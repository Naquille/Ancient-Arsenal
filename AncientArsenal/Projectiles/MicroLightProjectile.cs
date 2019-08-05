using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Projectiles
{
    class MicroLightProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Hallowed Shard");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 16;
            projectile.timeLeft = 120;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.melee = true;
            projectile.aiStyle = 207;
            projectile.penetrate = 3;
            projectile.light = 0.5f;
        }
       
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
            Vector2 randVect = new Vector2(Main.rand.Next(-15, 15), Main.rand.Next(-15, 15));
            int dustnumber = Dust.NewDust(projectile.position + randVect, projectile.width, projectile.height, 73, 0f, 0f, 100, default(Color), 1.2f);
            Main.dust[dustnumber].velocity = projectile.velocity * 0.5f;
            Main.dust[dustnumber].noGravity = true;
           
        }
    }
}