using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraJ.Items {
	public class AdvantureSword : TerraJItem {
		public override void SetDefaults() {
			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override string ItemName => "AdventureSword";
	}
}