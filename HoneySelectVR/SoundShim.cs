using Harmony;
using System.Reflection;

namespace HoneySelectVR
{
    class VoiceShim
    {
        public static void Inject()
        {
            var harmony = HarmonyInstance.Create("com.zerothangel.HoneySelectVR.PosAudioFix");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(Manager.Voice))]
        [HarmonyPatch("Play")]
        class Play
        {
            public static void Prefix(ref bool force2D)
            {
                force2D = false;
            }
        }
    }
}
