using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace CrystallineMod.PrehardmodeArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class SlimeHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SlimeHelmet");
		}

		public override void SetDefaults()
		{
			item.width = 5;
			item.height = 19;
			item.defense = 1;
			item.value = 2000;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SlimeChestplate>() && legs.type == ModContent.ItemType<SlimeBoots>();
		}
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Allows you to jump on enemies like the Slime Mount";
			player.armorEffectDrawShadow = true;

			var checkDamagePlayer = player.getRect();
			checkDamagePlayer.Offset(0, player.height - 1);
			checkDamagePlayer.Inflate(6, 0);
			for (var i = 0; i < 200; i++)
			{
				var npc = Main.npc[i];
				if (npc.active && !npc.dontTakeDamage && !npc.friendly && npc.immune[player.whoAmI] == 0)
				{
					var checkDamageNPC = npc.getRect();
					if (checkDamagePlayer.Intersects(checkDamageNPC) && (npc.noTileCollide || Collision.CanHit(player.position, player.width, player.height, npc.position, npc.width, npc.height)))
					{
						var damage = 15f * player.meleeDamage;
						var knockBack = 5f;
						var direction = player.direction;
						if (player.velocity.X < 0f)
						{
							direction = -1;
						}
						if (player.velocity.X > 0f)
						{
							direction = 1;
							if (player.whoAmI == Main.myPlayer)
							{
								npc.StrikeNPC((int)damage, knockBack, direction, false, false, false);
								if (Main.netMode != 0)
									NetMessage.SendData(28, -1, -1, NetworkText.FromLiteral(""), npc.whoAmI, 1, knockBack, direction, (int)damage);
							}
							npc.immune[player.whoAmI] = 20;
							player.velocity.Y = -7f;
							player.immune = true;
							break;
						}
					}
				}
			}



		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}