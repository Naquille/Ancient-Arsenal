using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.GolemBossBag)
            {
                player.QuickSpawnItem(mod.ItemType("GolemShard"), Main.rand.Next(2, 4));
            }
        }
    }
}