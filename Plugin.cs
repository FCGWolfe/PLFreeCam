using PulsarPluginLoader;


namespace PLFreeCam
{
    class Plugin : PulsarPlugin
    {
        public override string HarmonyIdentifier()
        {
            return "PLFreecam";
        }

        public override string Name => "PLFreecam";

        public override string Version => "1.0b";

        public override string Author => "FCGWolfe/Ship's Compooter";

        public override string ShortDescription => "Gives you an out-of-body-experience.";
    }
}

