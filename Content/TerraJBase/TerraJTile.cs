using Terraria.ModLoader;

namespace TerraJ.Content.TerraJBase;

public abstract class TerraJTile: ModTile {
    private readonly string setName;
    
    protected TerraJTile(string setName) {
        this.setName = setName;
    }

    public override void SetStaticDefaults() {
        var displayName = CreateMapEntryName();
        if (!string.IsNullOrEmpty(setName)) {
            
            displayName.SetDefault(setName);
        } else if (string.IsNullOrEmpty(setName)) {
            Logging.PublicLogger.Warn("Invalid item name! Using standard generated name");
            displayName.SetDefault("UnknownItem-" + TerraJ.Instance.UUID());
        }
        
        Properties();
    }
    
    protected virtual void Properties() {} 
}