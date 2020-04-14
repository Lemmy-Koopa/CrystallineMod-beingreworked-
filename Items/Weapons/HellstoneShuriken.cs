using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class HellstoneShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t burn yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 20f;
			item.damage = 23;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 16;
			item.useTime = 16;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.crit = 35;
			item.rare = 5;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 20);
			item.shoot = ProjectileType<HellstoneShurikenProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}



	}
}