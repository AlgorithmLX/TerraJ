using Terraria.ModLoader;

namespace TerraJ.Content.TerraJBase;

public abstract class TerraJTile: ModTile {
    public override void SetStaticDefaults() {
        ModTranslation translatableName = CreateMapEntryName();
        translatableName.SetDefault(SetName);
    }

    protected abstract string SetName { get; }

    
    
}