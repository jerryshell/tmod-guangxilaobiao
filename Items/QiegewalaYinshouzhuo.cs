using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class QiegewalaYinshouzhuo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("窃·格瓦拉的银手镯");
            Tooltip.SetDefault("生命再生提高 2 点/秒\n\"打工是不可能打工的，这辈子都不可能打工。\"");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 32;
            Item.maxStack = 1;
            Item.value = Item.buyPrice(0, 2);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;

            Item.defense = 10;
            Item.lifeRegen = 2;
        }
    }
}
