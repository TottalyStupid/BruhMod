using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BruhMod.Items
{
	public class CatBlade : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BruhMod.hjson file.

		public override void SetDefaults()
		{	
			Item.damage = 702;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 58;
			Item.useTime = 3;
			Item.useAnimation = 3;
			Item.shootSpeed = 15f;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.NightBeam;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Meowmere, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
}