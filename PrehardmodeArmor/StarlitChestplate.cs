using Terraria.ModLoader;
using Terraria.ID;

namespace CrystallineMod.PrehardmodeArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class StarlitChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("StarlitChestplate");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.defense = 4;
			item.value = 25000;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Star, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
