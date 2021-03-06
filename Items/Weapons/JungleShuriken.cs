﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class JungleShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 20f;
			item.damage = 23;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 18;
			item.useTime = 18;
			item.width = 32;
			item.height = 32;
			item.crit = 35;
			item.rare = 5;
			item.consumable = false;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 20);
			item.shoot = ProjectileType<JungleShurikenProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 10);
			recipe.AddIngredient(ItemID.JungleSpores);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



	}
}