using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuangxiLaobiao.Items
{
    public class LiuzhouLuosifen : ModItem
    {
        public override void SetStaticDefaults()
        {
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