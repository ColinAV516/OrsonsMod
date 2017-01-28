using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using System.Collections.Generic;

namespace OrsonsMod.Items.Weapons
{
	public class NebulaSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Nebula Sword";
			item.damage = 85;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 1000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
    		player.AddBuff(BuffID.ManaRegeneration, 1800);
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(Terraria.ID.ItemID.LunarBar, 10);
			recipe.AddTile(Terraria.ID.TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}