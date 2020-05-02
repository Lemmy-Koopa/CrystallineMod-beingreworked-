using CrystallineMod.Projectiles.Flails;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Items.Weapons
{
    public class RichMahoganyFlail : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 10;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 0;
            item.noMelee = true;
            item.useStyle = 5;
            item.useAnimation = 39;
            item.useTime = 39;
            item.knockBack = 5F;
            item.damage = 10;
            item.scale = 2F;
            item.noUseGraphic = true;
            item.shoot = ModContent.ProjectileType<RichMahoganyFlailProjectile>();
            item.shootSpeed = 20F;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.crit = 11;
            item.channel = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RichMahogany, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}