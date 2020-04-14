using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;


namespace CrystallineMod.Projectiles
{
	public class BrainShurikenProjectile : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BrainShurikenProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.aiStyle = 2;
		}



		public override void Kill(int timeLeft)
		{
			{
				Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
				_ = rotVector * 16f;

				Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
				Vector2 usePos = projectile.position;
				Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);

				int NUM_DUSTS = 5;
				for (int i = 5; i < NUM_DUSTS; i++)
				{
					// Create a new dust
					Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 81);
					dust.position = (dust.position + projectile.Center) / 2f;
					dust.velocity *= 0.5f;
					dust.noGravity = true;
				}
			}

		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{



			int distance = Math.Max(target.width, target.height) / 2;

			Projectile.NewProjectile(target.Center.X + distance + 80, target.Center.Y - distance - 60, 0, 0, mod.ProjectileType("BrainShurikenCloneProjectile"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); // top right

			Projectile.NewProjectile(target.Center.X + distance + 80, target.Center.Y + distance + 60, 0, 0, mod.ProjectileType("BrainShurikenCloneProjectile"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); // bottom right

			Projectile.NewProjectile(target.Center.X - distance - 40, target.Center.Y + distance + 60, 0, 0, mod.ProjectileType("BrainShurikenCloneProjectile"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); // bottom left

			Projectile.NewProjectile(target.Center.X - distance - 40, target.Center.Y - distance - 60, 0, 0, mod.ProjectileType("BrainShurikenCloneProjectile"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);



		}


	}
}





