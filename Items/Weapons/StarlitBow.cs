using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles.Ammo.Arrows;

namespace CrystallineMod.Items.Weapons
{
	public class StarlitBow : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 35;
			item.height = 60;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 13;
			item.rare = 4;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Arrow;

		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ModContent.ProjectileType<StarlitArrow>();
			}
			return true;
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