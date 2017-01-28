using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace OrsonsMod.Items
{
    public class AstatineOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Astatine Ore";
            item.width = 25;
            item.height = 20;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 1000;
            item.createTile = mod.TileType("Astatine_Ore");
			item.rare = 8;
        }
    }
}