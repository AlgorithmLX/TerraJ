using Terraria.Localization;
using Terraria.ModLoader;

namespace TerraJ.Content.TerraJBase;

public abstract class TerraJItem: ModItem {
    public override void SetStaticDefaults() {
        if (SetName != null) {
            DisplayName.AddTranslation(GameCulture.DefaultCulture, SetName);
        } else if (string.IsNullOrEmpty(SetName)) {
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
        
        Properties();
    }

    protected abstract string SetName { get; }
    protected virtual string TooltipMessage { get; }
    protected virtual void Properties() {}
}