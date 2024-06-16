using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace BruhMod.Items
{
    public class ChaosBlade : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = Item.sellPrice(silver: 30);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override bool? UseItem(Player player)
        {
            Tile centerTile = Framing.GetTileSafely(player.Center);

            int totalNPCs = NPCLoader.NPCCount;

            for (int i = 0; i < 5; i++)
            {
                NPC npc = new NPC();
                npc.SetDefaults(Main.rand.Next(totalNPCs));

                if ((!Main.hardMode && npc.boss)
                    || (!NPC.downedGolemBoss && (npc.type == NPCID.DD2Betsy || npc.type == NPCID.MartianProbe))
                    || (!NPC.downedAncientCultist && (npc.type == NPCID.LunarTowerNebula || npc.type == NPCID.LunarTowerSolar || npc.type == NPCID.LunarTowerStardust || npc.type == NPCID.LunarTowerVortex)))
                {
                    i--;
                    continue;
                }

                if (Main.dayTime)
                {
                    if (npc.lifeMax > 200 || npc.boss || npc.townNPC || npc.dontTakeDamage || npc.type == NPCID.BoundGoblin || npc.type == NPCID.BoundMechanic || npc.type == NPCID.BoundWizard || npc.type == NPCID.BartenderUnconscious || npc.type == NPCID.WebbedStylist)
                    {
                        i--;
                    }
                    else
                    {
                        NPC.NewNPC(player.GetSource_ItemUse(Item), (int)player.position.X + Main.rand.Next(-800, 800), (int)player.position.Y + Main.rand.Next(-1000, -250), npc.type);
                    }
                }
                //night
                else
                {
                    if (npc.townNPC || npc.dontTakeDamage || npc.type == NPCID.BoundGoblin || npc.type == NPCID.BoundMechanic || npc.type == NPCID.BoundWizard || npc.type == NPCID.BartenderUnconscious || npc.type == NPCID.WebbedStylist || npc.type == NPCID.LunarTowerNebula || npc.type == NPCID.LunarTowerSolar || npc.type == NPCID.LunarTowerStardust || npc.type == NPCID.LunarTowerVortex)
                    {
                        i--;
                    }
                    else
                    {
                        NPC.NewNPC(player.GetSource_ItemUse(Item), (int)player.position.X + Main.rand.Next(-800, 800), (int)player.position.Y + Main.rand.Next(-1000, -250), npc.type);
                    }
                }
            }

            SoundEngine.PlaySound(SoundID.Roar, player.position);
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 100) // Example ingredient
                .AddIngredient(ItemID.StoneBlock, 100) // Example ingredient
                .AddIngredient(ItemID.Wood, 100) // Example ingredient
                .AddTile(TileID.Anvils) // Example crafting station
                .Register();
        }
    }
}
