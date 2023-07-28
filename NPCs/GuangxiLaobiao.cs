using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace GuangxiLaobiao.NPCs
{
    [AutoloadHead]
    public class GuangxiLaobiao : ModNPC
    {
        public const string ShopName = "商店";

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 25;

            NPCID.Sets.ExtraFramesCount[Type] = 9;
            NPCID.Sets.AttackFrameCount[Type] = 4;
            NPCID.Sets.DangerDetectRange[Type] = 500;
            NPCID.Sets.AttackType[Type] = 1;
            NPCID.Sets.AttackTime[Type] = 30;
            NPCID.Sets.AttackAverageChance[Type] = 10;
            NPCID.Sets.HatOffsetY[Type] = 4;
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 40;
            NPC.aiStyle = 7;
            NPC.damage = 70;
            NPC.defense = 14;
            NPC.lifeMax = 300;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.2f;

            AnimationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs)
        {
            return true;
        }


        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "没有内鬼，继续交易！";
            button2 = "[偷他的电瓶车]";
        }

        public override string GetChat()
        {
            return "此处停车 = 走路回家";
        }

        public override void OnChatButtonClicked(bool firstButton, ref string shopName)
        {
            if (firstButton)
            {
                shopName = ShopName;
            }
            else
            {
                NPC.townNPC = false;
                NPC.friendly = false;
                NPC.value = 20000f;
                NPC.aiStyle = 3;
                AIType = NPCID.SkeletonArcher;
            }
        }

        // public override void SetupShop(Chest shop, ref int nextSlot)
        // {
        //     shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.NanningLaoyoufen>(), false);
        //     nextSlot++;
        //     shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.LiuzhouLuosifen>(), false);
        //     nextSlot++;
        //     shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.GuilinMifen>(), false);
        //     nextSlot++;
        //     shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.QiegewalaYinshouzhuo>(), false);
        //     nextSlot++;
        // }

        public override void AddShops()
        {
            var npcShop = new NPCShop(Type, ShopName)
                .Add(ModContent.ItemType<Items.NanningLaoyoufen>())
                .Add(ModContent.ItemType<Items.LiuzhouLuosifen>())
                .Add(ModContent.ItemType<Items.GuilinMifen>())
                .Add(ModContent.ItemType<Items.QiegewalaYinshouzhuo>());

            npcShop.Register();
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.NanningLaoyoufen>()));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.LiuzhouLuosifen>()));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.GuilinMifen>()));
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 70;
            knockback = 2f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.WoodenArrowFriendly;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 7f;
        }
    }
}