using TerraJ.Content.TerraJBase;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraJ.Content.Items;

public class AdvantureSword: TerraJItem {
	public AdvantureSword() : base("AdvantureSword", "AdvantureSwordTooltip") {
	}

	protected override void Properties() {
		Item.damage = 16;
		Item.DamageType = DamageClass.Default;
		Item.useTime = 20;
		Item.useAnimation = 20;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 1;
		Item.value = 10000;
		Item.rare = ItemRarityID.Expert;
		Item.UseSound = SoundID.Item1;
		Item.autoReuse = true;
	}

	public override void AddRecipes() => CreateRecipe()
		.AddIngredient(ItemID.Gel, 2)
		.AddTile(TileID.WorkBenches)
		.Register();
	
}