using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class NanningLaoyoufen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("南宁老友粉");
            Tooltip.SetDefault("所有属性小幅提升(60分钟)\n移动速度和采矿速度提高20%(5分钟)\n南宁传统小吃的金字招牌，其口味鲜辣、汤料香浓，具有开胃解腻、驱风散寒、通窍醒脑的独特功效，属于桂菜。");
            ItemID.Sets.IsFood[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.DefaultToFood(22, 22, BuffID.WellFed, 216000);
            Item.value = Item.buyPrice(0, 0, 1);
            Item.rare = ItemRarityID.White;
        }

        public override void OnConsumeItem(Player player)
        {
            player.AddBuff(BuffID.SugarRush, 18000);
        }
    }
}