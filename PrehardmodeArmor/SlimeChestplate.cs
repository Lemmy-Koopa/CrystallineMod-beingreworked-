using Terraria.ModLoader;
using Terraria.ID;

namespace CrystallineMod.PrehardmodeArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class SlimeChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SlimeChestplate");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.defense = 2;
			item.value = 25000;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}