using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace BruhMod.Items.Ammo
{
	// Token: 0x02000131 RID: 305
	public class AbobaAmmo : ModItem
	{


		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.maxStack = 1;
			Item.value = Item.sellPrice(0, 1, 0, 0);
			Item.rare = 2;
			Item.ammo = AmmoID.Gel;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000274AF File Offset: 0x000256AF
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Gel, 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}