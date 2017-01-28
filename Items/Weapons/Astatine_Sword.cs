using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OrsonsMod.Items.Weapons
{
	public class Astatine_Sword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Astatine Sword";
			item.damage = 190;
			item.melee = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 80000;
			item.rare = 8;
			item.crit = 4;
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
