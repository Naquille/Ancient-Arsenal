using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class PyrexianHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pyrexian Mask");
            Tooltip.SetDefault("+8% increased magic and ranged damage and critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 24;
            item.value = 110000;
            item.rare = 2;
            item.defense = 12;
            item.rare = 7;
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage *= 1.08f;
            player.magicDamage *= 1.08f;
            player.magicCrit += 8;
            player.rangedCrit += 8;

        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PyrexianPlatemail") && legs.type == mod.ItemType("PyrexianGrieves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Immune to 'On Fire!'" + "\n -5% mana cost" + "\n 8% increased ranged damage";
            player.buffImmune[BuffID.OnFire] = true;
            player.manaCost *= 0.95f;
            player.rangedDamage *= 1.08f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 16);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}