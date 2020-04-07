
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class StarlitTomb : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");

		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.magic = true;
			item.mana = 7;
			item.width = 32;
			item.height = 34;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileType<StarProjectile>();
			item.shootSpeed = 16f;
			item.holdStyle = 3;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
			{
				position = player.Center + new Vector2(-(float)Main.rand.Next(0, 401) * player.direction, -600f);
				position.Y -= 100 * i;
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Star, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}