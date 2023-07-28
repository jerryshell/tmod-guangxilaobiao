using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class GuilinMifen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("桂林米粉");
            Tooltip.SetDefault("所有属性大幅提升(60分钟)\n移动速度和采矿速度提高20%(30分钟)\n桂林米粉是桂林市的一道传统小吃，属于桂菜系；该菜品以早籼米和卤水为原料。\n做出来的米粉本身淡而无味，美味的桂林米粉关键在卤水。\n店家熬制的卤水都有各自的绝招，一般每家店都不同，而且一般不将配方外传，作为商业秘密。");
            ItemID.Sets.IsFood[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.DefaultToFood(22, 22, BuffID.WellFed3, 216000);
            Item.value = Item.buyPrice(0, 1);
            Item.rare = ItemRarityID.Blue;
        }

        public override void OnConsumeItem(Player player)
        {
            player.AddBuff(BuffID.SugarRush, 108000);
        }
    }
}