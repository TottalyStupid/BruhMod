using BruhMod.Items;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace BruhMod.NPCs
{
    [AutoloadHead]
    public class BruhPerson : ModNPC
    {
        public static string BaseShop = "BaseShop";
        public static string PlantShop = "PlantShop";
        public override string Texture
        {
            get
            {
                return "BruhMod/NPCs/BruhPerson";
            }
        }
        // Probably Removed
        // public override bool Autoload(ref string name)
        // {
        // 	name = "BruhPerson";
        // 	return true;
        // }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 23;
            NPCID.Sets.AttackFrameCount[NPC.type] = 2;
            NPCID.Sets.DangerDetectRange[NPC.type] = 500;
            NPCID.Sets.AttackType[NPC.type] = 0;
            NPCID.Sets.AttackTime[NPC.type] = 22;
            NPCID.Sets.AttackAverageChance[NPC.type] = 30;
            NPCID.Sets.HatOffsetY[NPC.type] = -4;

            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = -1f,
                Direction = -1
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);

            NPC.Happiness.SetBiomeAffection<ForestBiome>(AffectionLevel.Like);
            NPC.Happiness.SetBiomeAffection<SnowBiome>(AffectionLevel.Love);
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Underground,
                new FlavorTextBestiaryInfoElement("Mods.BruhMod.Bestiary.BruhPerson")
            });
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 40;
            NPC.aiStyle = 7;
            NPC.damage = 10;
            NPC.defense = 100;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.Clothier;
        }

        public override List<string> SetNPCNameList()
        {                                       //NPC names
            string Edward = Language.GetTextValue("Mods.AlchemistNPCLite.Edward");
            string Severus = Language.GetTextValue("Mods.AlchemistNPCLite.Severus");
            string Horace = Language.GetTextValue("Mods.AlchemistNPCLite.Horace");
            string Tilyorn = Language.GetTextValue("Mods.AlchemistNPCLite.Tilyorn");
            string Nicolas = Language.GetTextValue("Mods.AlchemistNPCLite.Nicolas");
            string Gregg = Language.GetTextValue("Mods.AlchemistNPCLite.Gregg");

            return new List<string>() {
                Edward,
                Severus,
                Horace,
                Tilyorn,
                Nicolas,
                Gregg
            };
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            if (!Main.hardMode)
            {
                damage = 10;
            }
            if (!NPC.downedMoonlord && Main.hardMode)
            {
                damage = 25;
            }
            if (NPC.downedMoonlord)
            {
                damage = 100;
            }
            knockback = 8f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 15;
            randExtraCooldown = 5;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.RainbowRodBullet;
            }
            else
            {
                projType = ProjectileID.MagicMissile;
            }
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }

        public override string GetChat()
        {                                           //npc chat
            string EntryA1 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA1");
            string EntryA2 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA2");
            string EntryA3 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA3");
            string EntryA4 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA4");
            string EntryA5 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA5");
            string EntryA6 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA6");
            string EntryA7 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA7");
            string EntryA8 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA8");
            string EntryA9 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA9");
            string EntryA10 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA10");
            string EntryA11 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA11");
            string EntryA12 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA12");
            string EntryA13 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA13");
            string EntryA14 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA14");
            string EntryA15 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA15");
            string EntryA16 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA16");
            string EntryA17 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA17");
            string EntryA18 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA18");
            string EntryA19 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA19");
            string EntryA20 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA20");
            string EntryA21 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA21");
            string EntryA22 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA22");
            string EntryA23 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA23");
            string EntryA24 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA24");
            string EntryA25 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA25");
            string EntryA26 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA26");
            string EntryA27 = Language.GetTextValue("Mods.AlchemistNPCLite.EntryA27");
            int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            if (Main.bloodMoon && partyGirl >= 0 && Main.rand.NextBool(4))
            {
                return EntryA23 + Main.npc[partyGirl].GivenName + EntryA24;
            }
            if (Main.bloodMoon)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        return EntryA20;
                    case 1:
                        return EntryA21;
                    case 2:
                        return EntryA22;
                }
            }
            if (Main.invasionType == 1)
            {
                return EntryA17;
            }
            if (Main.invasionType == 3)
            {
                return EntryA18;
            }
            if (Main.invasionType == 4)
            {
                return EntryA19;
            }
            switch (Main.rand.Next(7))
            {
                case 0:
                    return EntryA1;
                case 1:
                    return EntryA2;
                case 2:
                    return EntryA3;
                case 3:
                    return EntryA4;
                case 4:
                    return EntryA5;
                case 5:
                    return EntryA6;
                default:
                    return EntryA7;
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            string Shop = Language.GetTextValue("Mods.BruhMod.Shop");
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = Shop;
        }

        public override void OnChatButtonClicked(bool firstButton, ref string shopName)
        {
            if (firstButton)
            {
                shopName = BaseShop;
            }
        }

        public override void AddShops()
        {
            var shop = new NPCShop(Type, BaseShop)
                .Add(new Item(ItemID.FirstFractal) { shopCustomPrice = 15000 })
                .Add(new Item(ItemID.BoringBow) { shopCustomPrice = 15000 })
                .Add(new Item(ItemID.OgreMask) { shopCustomPrice = 15000 })
                .Add(new Item(ItemID.GoblinMask) { shopCustomPrice = 15000 });
            shop.Register();
        }
    }
}
