using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class LiuzhouLuosifen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("柳州螺蛳粉");
            Tooltip.SetDefault("所有属性中幅提升(60分钟)\n移动速度和采矿速度提高20%(12分钟)\n广西柳州的风味小吃\n由柳州特有的米粉，加上酸笋、木耳、花生、油炸豆皮、黄花菜、青菜等配料及适度的酸辣味和煮淡水石螺的汤水调合而成\n具有酸、辣、鲜、爽、烫的风味及酸笋的特殊气味。\n正宗的螺蛳粉不放螺蛳，只是汤用螺蛳熬成，好的螺蛳汤应清而不淡、麻而不燥、辣而不火、香而不腻。");
            ItemID.Sets.IsFood[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.DefaultToFood(22, 22, BuffID.WellFed2, 216000);
            Item.value = Item.buyPrice(0, 0, 10);
            Item.rare = ItemRarityID.Green;
        }

        public override void OnConsumeItem(Player player)
        {
            player.AddBuff(BuffID.SugarRush, 43200);
        }
    }
}