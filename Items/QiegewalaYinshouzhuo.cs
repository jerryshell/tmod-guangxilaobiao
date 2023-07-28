using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class QiegewalaYinshouzhuo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
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
