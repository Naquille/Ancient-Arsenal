
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Tiles
{
    public class EndolyteOreTile : ModTile
    {
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            if (tile.frameX == 0)
            {
                // We can support different light colors for different styles here: switch (tile.frameY / 54)
                r = 1f;
                g = 0.6f;
                b = 0.01f;
            }
        }
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
            Main.tileValue[Type] = 410;
            Main.tileShine2[Type] = true; // Modifies the draw color slightly.
            Main.tileShine[Type] = 975; // How often tiny dust appear off this tile. Larger is less frequently
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = false;
            

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Endolyte");
            AddMapEntry(new Color(235, 40, 70), name);

            dustType = 84;
            drop = mod.ItemType("EndolyteOreItem");
            soundType = 21;
            soundStyle = 1;
            mineResist = 3f;
            minPick = 200;
        }
    }
}