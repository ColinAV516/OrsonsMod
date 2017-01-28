using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OrsonsMod.Items.Weapons
{
	public class Void_knife : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Void Knife";
			item.damage = 15;
			item.melee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 35;
			item.useAnimation = 5;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 1200;
			item.rare = 2;
			item.crit = 7;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
