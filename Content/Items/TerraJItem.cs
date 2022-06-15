using Terraria.Localization;
using Terraria.ModLoader;

namespace TerraJ.Content.Items;

public abstract class TerraJItem: ModItem {
    public override string Texture => TerraJ.ModName + "/Items/Textures/" + ItemName;

    public override void SetStaticDefaults() {
        if (ItemName != null) {
            DisplayName.AddTranslation(GameCulture.DefaultCulture, ItemName);
        } else if (string.IsNullOrEmpty(ItemName)) {
            Logging.PublicLogger.Warn("Invalid item name! Using standard generated name");
            DisplayName.SetDefault("UnknownItem-" + TerraJ.Instance.UUID());
        }

        if (!string.IsNullOrEmpty(TooltipMessage)) 
            Tooltip.SetDefault(TooltipMessage); 
        else if (string.IsNullOrEmpty(TooltipMessage))
            Tooltip.SetDefault("");
    }

    public override void SetDefaults() {
        Item.width = 16;
        Item.height = 16;
        Item.knockBack = 0;
        Item.damage = 0;
    }

    protected abstract string ItemName { get; }
    protected virtual string TooltipMessage { get; }
}