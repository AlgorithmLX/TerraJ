using Terraria.ID;
using Terraria.ModLoader;

namespace TerraJ.Content.Items;

public class AdvantureSword: TerraJItem {
	public override void SetDefaults() {
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

	protected override string ItemName => "AdventureSword";
	protected override string TooltipMessage => "AdvantureSwordTooltip";

	public override void AddRecipes() => CreateRecipe()
		.AddIngredient(ItemID.Gel, 2)
		.AddTile(TileID.Adamantite)
		.Register();

}