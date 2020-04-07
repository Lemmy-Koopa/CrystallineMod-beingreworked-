using Terraria.ID;
using Terraria.ModLoader;
using Terraria;


namespace CrystallineMod.Projectiles
{
    class SlimerangProjectile : ModProjectile
    {



        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 30;
            projectile.CloneDefaults(ProjectileID.WoodenBoomerang);
            projectile.friendly = true;
            projectile.melee = true;
            projectile.extraUpdates = 1;
            projectile.tileCollide = false;
            projectile.penetrate = 2;
        }


        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            {
                target.AddBuff(BuffID.Slimed, 60);





            }
        }
    }
}
