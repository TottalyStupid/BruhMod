using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BruhMod.Items
{
	public class Aboba : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BruhMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 820000000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 466;
			Item.height = 110;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 1800;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
	}
}