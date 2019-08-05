using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace AncientArsenal.Items
{
    public class GolemShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golem Shard");
            Tooltip.SetDefault("'The power of the automaton'");
        }
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 58;
            item.value = 50000;
            item.rare = 7;
            item.maxStack = 99;
        }
    }
}