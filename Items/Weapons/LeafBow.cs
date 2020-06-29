using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class LeafBow : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 35;
			item.height = 60;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 13;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Arrow;

		}
         public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodBow, 1);
            recipe.AddIngredient(mod.ItemType());//leaf
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
			type = Main.rand.Next(new int[] { type, ProjectileID.Arrow, ProjectileType<Projectiles.LeafProjectile>() });
			return true;
		}
    }
}