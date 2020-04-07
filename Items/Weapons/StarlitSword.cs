using Terraria.ID;
using Terraria.ModLoader;
using System;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class StarlitSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("yeahno"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("H.");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileType<StarProjectile>();
			item.shootSpeed = 8;
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