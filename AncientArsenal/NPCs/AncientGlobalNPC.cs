using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.NPCs
{
    public class AncientGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Golem && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("GolemShard"), Main.rand.Next(1, 3));
            }
        }
    }
}