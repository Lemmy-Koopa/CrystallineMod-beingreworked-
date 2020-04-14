using Terraria.ModLoader;
using Terraria.ID;

namespace CrystallineMod.PrehardmodeArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SlimeBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SlimeBoots");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.defense = 1;
			item.value = 25000;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}