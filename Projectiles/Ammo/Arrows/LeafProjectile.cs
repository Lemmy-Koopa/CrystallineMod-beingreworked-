using Terraria;
using Terraria.ModLoader;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Projectiles.Ammo.Arrows
{
    public class LeafProjectile : ModProjectile
    {


        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 25;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.aiStyle = 0;
        }
    }
}