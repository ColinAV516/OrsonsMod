using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OrsonsMod.Tiles
{
    public class Astatine_Ore : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("AstatineOre"); 
            AddMapEntry(new Color(30, 129, 10));
        }
      
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) 
        {
            r = 0.3f;
            g = 1.2f;
            b = 0.1f;
        }
    }
}