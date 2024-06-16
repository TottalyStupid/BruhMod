using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace BruhMod.Items
{
	public class SussyGussy : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BruhMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 60;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 52;
			Item.height = 52;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.shootSpeed = 16f;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 1800;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item36;
			Item.autoReuse = true;
			Item.noMelee = true;
			Item.shoot = ProjectileID.StickyGrenade;
		}
	}
}