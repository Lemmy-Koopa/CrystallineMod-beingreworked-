using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class BrainShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 15f;
			item.damage = 12;
			item.knockBack = 2f;
			item.useStyle = 1;
			item.useAnimation = 16;
			item.useTime = 16;
			item.width = 32;
			item.height = 32;
			item.crit = 50;
			item.rare = 5;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 20);
			item.shoot = ProjectileType<BrainShurikenProjectile>();
		}

	}
}