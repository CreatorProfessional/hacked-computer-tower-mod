using BTD_Mod_Helper;
using MelonLoader;

[assembly: MelonInfo(typeof(HackedComputerTowerMod.Main), "Hacked Computer Tower Mod", "1.0.0", "SodaleafAhsan")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CardMonkey
{
    public class Main : BloonsTD6Mod
    {
        public override string MelonInfoCsURL =>
            "https://raw.githubusercontent.com/CreatorProfessional/hacked-computer-tower-mod/main/Main.cs";

        public override string LatestURL =>
            "https://github.com/CreatorProfessional/hacked-computer-tower-mod/blob/main/HackedComputerTowerMod.dll?raw=true";

        // No Harmony Patches or hooks required for this whole tower!
    }
}
