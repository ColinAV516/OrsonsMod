using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OrsonsMod.Tiles
{
	class Astatine_Bar_placed : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileBlockLight[Type] = false;
			animationFrameHeight = 16;
			AddMapEntry(new Color(9, 9, 9), "Astatine Bars");
			drop = mod.ItemType("Astatine_Bar"); 
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.3f;
            g = 1.2f;
            b = 0.1f;
		}
	}
}