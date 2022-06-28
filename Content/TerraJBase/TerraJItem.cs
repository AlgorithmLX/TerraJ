namespace TerraJ.Content.TerraJBase;

using Terraria.Localization;
using Terraria.ModLoader;

public class TerraJItem : ModItem {
    private readonly string name;
    private readonly string tMsg;
    
    protected TerraJItem(string name, string tMsg) {
        this.tMsg = tMsg;
        this.name = name;
    }
    
    protected TerraJItem(string name) {
        this.tMsg = "";
        this.name = name;
    }
    
    protected TerraJItem() {
        this.tMsg = "";
        this.name = "";
    }

    public override string Texture => TerraJ.ModName + "/Assets/Items/" + name;

    public override void SetStaticDefaults() {
        if (name != null) 
            DisplayName.AddTranslation(GameCulture.DefaultCulture, name);
        else if (string.IsNullOrEmpty(name)) {
            Logging.PublicLogger.Warn("Invalid item name! Using standard generated name");
            DisplayName.SetDefault("UnknownItem-" + TerraJ.Instance.UUID());
        }

        if (!string.IsNullOrEmpty(tMsg)) 
            Tooltip.SetDefault(tMsg); 
        else if (string.IsNullOrEmpty(tMsg))
            Tooltip.SetDefault("");
    }

    public override void SetDefaults() {
        Item.width = 16;
        Item.height = 16;
        
        Properties();
    }
    
    protected virtual void Properties() {}
}