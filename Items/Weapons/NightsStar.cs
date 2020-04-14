using CrystallineMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod.Items.Weapons
{
	public class NightsStar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 30f;
			item.damage = 28;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 15;
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
			item.shoot = ProjectileType<NightsStarProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EyeShuriken"));
			recipe.AddIngredient(mod.ItemType("HellstoneShuriken"), 300);
			recipe.AddIngredient(mod.ItemType("JungleShuriken"));
			recipe.AddIngredient(mod.ItemType("WaterShuriken"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



	}
}