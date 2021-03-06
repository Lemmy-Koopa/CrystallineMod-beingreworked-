﻿using CrystallineMod.Projectiles.Flails;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Items.Weapons
{
    public class BorealFlail : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 10;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.rare = 0;
            item.noMelee = true;
            item.useStyle = 5;
            item.useAnimation = 39;
            item.useTime = 39;
            item.knockBack = 4F;
            item.damage = 9;
            item.scale = 2F;
            item.noUseGraphic = true;
            item.shoot = ModContent.ProjectileType<BorealFlailProjectile>();
            item.shootSpeed = 20F;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.crit = 11;
            item.channel = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BorealWood, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}