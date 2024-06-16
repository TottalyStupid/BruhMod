using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BruhMod.Items
{
	public class ColorRevolution : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BruhMod.hjson file.

		public override void SetDefaults()
		{	
			Item.CloneDefaults(ItemID.Meowmere);

			Item.damage = 580;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 58;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.shootSpeed *= 1.25f;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.Meowmere;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CrystalShard, 3);
			recipe.AddIngredient(ItemID.Meowmere, 2);
			recipe.AddIngredient(ItemID.PurpleDye, 2);
			recipe.AddIngredient(ItemID.PinkDye, 2);
			recipe.AddIngredient(ItemID.BlueDye, 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
}