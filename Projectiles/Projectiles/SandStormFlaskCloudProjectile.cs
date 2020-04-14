using Terraria.ID;
using Terraria.ModLoader;
using Terraria;


namespace CrystallineMod.Projectiles
{
    class SandStormFlaskCloudProjectile : ModProjectile
    {



        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 30;
            projectile.CloneDefaults(ProjectileID.ToxicCloud);
            projectile.friendly = true;
            projectile.melee = true;
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
            projectile.penetrate = 2;
        }
    }
}
