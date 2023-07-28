using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class GuilinMifen : ModItem
    {
        public override void SetStaticDefaults()
        {
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