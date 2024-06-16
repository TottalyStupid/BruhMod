using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace BruhMod.Items
{
	public class AbobaGun : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BruhMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 382421758;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 466;
			Item.height = 110;
			Item.useTime = 1;
			Item.useAnimation = 1;
			Item.shootSpeed = 7f;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 1800;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item36;
			Item.autoReuse = true;
			Item.noMelee = true;
			Item.shoot = ProjectileID.Bullet;
		}
	}
}