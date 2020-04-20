using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    public class PumpkinDaggerProjectileB : ModProjectile
    {
        public override void SetDefaults()
        {
            //projectile.name = "Pumpkin Dagger";
            projectile.width = 14;
            projectile.height = 30;
            projectile.aiStyle = 113;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 568;
            projectile.alpha = 255;
            projectile.extraUpdates = 1;
            projectile.light = 0;
            aiType = ProjectileID.BoneJavelin;

        }

        public override void AI()
        {
            Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 2);
            }
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
        }
    }
}