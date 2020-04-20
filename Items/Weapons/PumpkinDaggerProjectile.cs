using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    public class PumpkinDaggerProjectile : ModProjectile
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
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.extraUpdates = 1;
            projectile.light = 0;
            aiType = ProjectileID.BoneJavelin;

        }
        public virtual bool? CanCutTiles()
        {
            return true;
        }

        public override void AI()
        {
            if (projectile.timeLeft < 570)
            {
                if (projectile.timeLeft > 568)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        float speedX = projectile.velocity.X * 0.8f/* + Main.rand.NextFloat(4f, 8f)*/;
                        float speedY = projectile.velocity.Y * 0.8f * 0.01f + Main.rand.Next(-5, 5) * 0.4f;
                        Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y + speedY, speedX, speedY, mod.ProjectileType("PumpkinDaggerProjectileB"), (int)(projectile.damage * 0.8), 0f, Main.myPlayer, 0f, 1f);
                    }
                }

            }

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