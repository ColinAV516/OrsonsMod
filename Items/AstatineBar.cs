using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

namespace OrsonsMod.Items
{
	public class AstatineBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Astatine Bar";
			item.toolTip = ("It Shines With Pure Power");
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 5000;
			item.createTile = mod.TileType("Astatine_Bar_placed");
			item.rare = 8;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AstatineOre", 1);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}