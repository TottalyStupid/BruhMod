using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace BruhMod.Items.Ammo
{
	// Token: 0x02000131 RID: 305
	public class IcyAmmo : ModItem
	{


		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 9999;
			Item.value = Item.sellPrice(0, 0, 0, 1);
			Item.rare = 2;

			Item.damage = 17;
			Item.DamageType = DamageClass.Ranged;
			Item.shootSpeed = 10f;

			Item.consumable = true;
			Item.ammo = AmmoID.Bullet;
			Item.shoot = ProjectileID.IceBolt;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000274AF File Offset: 0x000256AF
		public override void AddRecipes()
		{
			CreateRecipe(50).
            	AddIngredient(ItemID.IceBlock).
                AddIngredient(ItemID.EmptyBullet, 50).
                AddTile(TileID.IceMachine).
                Register();
		}
	}
}