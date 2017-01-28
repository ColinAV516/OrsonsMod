using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OrsonsMod.Items.Weapons
{
	public class AstatineWarAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Astatine War Axe";
			item.damage = 100;        //fine
			item.melee = true;
			item.width = 54;
			item.height = 54;
			item.useTime = 22;
			item.useAnimation = 20;
			item.axe = 250;         //fine
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 60000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AstatineBar", 10);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
