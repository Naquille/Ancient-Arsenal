using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
namespace AncientArsenal.World
{
    public class AncientWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("My Mod Ores", AncientArsenalModOres));
            }
        }
            private void AncientArsenalModOres(GenerationProgress progress)
        {
            progress.Message = "Heating Up Some Ore";
            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int x = WorldGen.genRand.Next(20, Main.maxTilesX -20);
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);
                WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("EndolyteOreTile"), false, 0f, 0f, false, true);
            }
        }
    }
}