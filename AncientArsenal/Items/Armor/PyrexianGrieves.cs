using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class PyrexianGrieves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pyrexian Grieves");
            Tooltip.SetDefault("15% increased movement speed"
            +"\n+6% increased magic and ranged damage and critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = 105000;
            item.rare = 4;
            item.defense = 17;
            item.rare = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.15f;
            player.magicCrit += 6;
            player.rangedCrit += 6;
            player.rangedDamage *= 1.06f;
            player.magicDamage *= 1.06f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 18);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}