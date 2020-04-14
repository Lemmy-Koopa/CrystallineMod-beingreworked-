using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod.Items.Weapons
{
	public class MythrilRevolver : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("OOf.");
		}

		public override void SetDefaults()
		{
			item.damage = 42;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
			item.crit = 5;

		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(0, 3));
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(382, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();


		}
	}
}
