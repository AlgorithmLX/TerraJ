using Terraria.ModLoader;

namespace TerraJ.Items {
    public class TerraJItem: ModItem {
        public override string Texture => "TerraJ/Textures/Items/" + ItemName;

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(ItemName);
        }

        public virtual string ItemName {
            get;
        }
        
    }
}