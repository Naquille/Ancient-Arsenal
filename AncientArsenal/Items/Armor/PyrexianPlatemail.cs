using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class PyrexianPlatemail : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Pyrexian Platemail");
            Tooltip.SetDefault("Hot Stuff"
                +"\n+6% increased magic and ranged damage and critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 20;
            item.value = 115000;
            item.rare = 2;
            item.defense = 10;
            item.rare = 4;

        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage *= 1.06f;
            player.magicDamage *= 1.06f;
            player.magicCrit+= 6;
            player.rangedCrit += 6;

            }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EndolyteBar"), 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}