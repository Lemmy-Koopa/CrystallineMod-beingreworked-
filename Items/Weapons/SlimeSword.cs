using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace CrystallineMod.Items.Weapons
{
    class SlimeSword : ModItem
    {

        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 51;
            item.height = 54;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.buyPrice(copper: 20);
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 30);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            {
                target.AddBuff(BuffID.Slimed, 60);

            }
        }
    }
}
