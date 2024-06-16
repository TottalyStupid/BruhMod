using static Terraria.Player;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace BruhMod.Items
{
    public class Infinity : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 52;
            Item.height = 52;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MusketBall, 3996);
			recipe.AddIngredient(ItemID.MeteorShot, 3996);
			recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996);
			recipe.AddIngredient(ItemID.MoonlordBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
    }
}