using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class SandStormFlask : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Homes in on nearby enemies");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 15f;
			item.damage = 14;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 28;
			item.useTime = 28;
			item.width = 32;
			item.height = 32;
			item.rare = 5;
			item.consumable = false;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 80);
			item.shoot = ProjectileType<SandStormFlaskProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
