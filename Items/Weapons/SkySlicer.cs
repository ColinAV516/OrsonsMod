using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OrsonsMod.Items.Weapons
{
	public class SkySlicer : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sky Slicer";
			item.damage = 22;
			item.melee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 10;
			item.crit = 3;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunplateBlock, 30);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
