
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CeriumSword
{
    public class CeriumSword : ModItem
    {
        public override void SetDefaults()
        {
            //item.name = "Cerium Sword";
            item.useStyle = 1;
            item.width = 9;
            item.height = 15;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            //item.channel = true;
            item.consumable = false;
            item.maxStack = 1;
            item.shoot = mod.ProjectileType("CeriumBolt");
            item.useAnimation = 14;
            item.useTime = 14;
            item.shootSpeed = 8.0f;
            item.damage = 24;
            item.knockBack = 6f;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.crit = 14;
            item.rare = 4;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1725, 35);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}