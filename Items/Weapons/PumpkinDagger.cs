using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Items.Weapons
{
    public class PumpkinDagger : ModItem
    {
        public override void SetDefaults()
        {
            //item.name = "Pumpkin Dagger";
            item.useStyle = 1;
            item.width = 9;
            item.height = 15;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item1;
            item.thrown = true;
            item.channel = true;
            item.noMelee = true;
            item.consumable = true;
            item.maxStack = 999;
            item.shoot = mod.ProjectileType("PumpkinDaggerProjectile");
            item.useAnimation = 14;
            item.useTime = 14;
            item.shootSpeed = 6.0f;
            item.damage = 11;
            item.knockBack = 3.5f;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.crit = 10;
            item.rare = 1;
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