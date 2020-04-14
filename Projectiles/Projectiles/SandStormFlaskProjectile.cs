using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod.Projectiles
{
	public class SandStormFlaskProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 19;
			projectile.height = 38;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.thrown = true;
		}

		public override void AI()
		{
			projectile.rotation += Math.Abs(projectile.velocity.X) * 0.04f * projectile.direction;
			ref float reference = ref projectile.ai[0];
			reference += 1f;
			if (projectile.ai[0] >= 20f)
			{
				projectile.velocity.Y = projectile.velocity.Y + 0.4f;
				projectile.velocity.X = projectile.velocity.X * 0.97f;
			}
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}
		}
		public override void Kill(int timeLeft)
		{
			Main.PlaySound(SoundID.Item107, projectile.position);

			int type = Main.rand.Next(new int[] { mod.ProjectileType("SandStormFlaskCloudProjectile"), mod.ProjectileType("SandStormFlaskCloudProjectile") });
			int num318 = Main.rand.Next(19, 21);
			for (int num319 = 0; num319 < num318; num319++)
			{
				Vector2 value16 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
				value16.Normalize();
				value16 *= Main.rand.Next(280, 481) * 0.0111f;
				Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, value16.X, value16.Y, type, projectile.damage, projectile.owner, 0, Main.rand.Next(-45, 1));
			}
		}
	}
}
