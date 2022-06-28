namespace TerraJ.Content.TerraJBase;

using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

public abstract class TerraJEntity : ModNPC {
    private readonly string name;
    private readonly int maxHP;
    private readonly int onExpertMultiperDamage;
    
    protected TerraJEntity(string name, int maxHP, int onExpertMultiperDamage) {
        this.name = name;
        this.maxHP = maxHP;
        this.onExpertMultiperDamage = onExpertMultiperDamage;
    }

    protected TerraJEntity(string name, int maxHP) {
        this.name = name;
        this.maxHP = maxHP;
        this.onExpertMultiperDamage = (int) 0.5;
    }

    public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
        NPC.lifeMax = (int) (NPC.lifeMax * onExpertMultiperDamage * bossLifeScale);
    }

    public override void SetStaticDefaults() {
        DisplayName.SetDefault(name);
    }

    public override void SetDefaults() {
        Properties();
    }

    public virtual void Properties() {}
    public virtual void EntityProperties() {}
}