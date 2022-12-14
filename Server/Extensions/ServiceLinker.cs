namespace LyftClient.Extensions
{
    // Summary: Stores all services with relation to their internal id
    public class ServiceLinker
    {
        public static readonly Dictionary<string, string> ServiceIDs = new Dictionary<string, string>
        {
            {"2B2225AD-9D0E-45E0-85FB-378FE2B521E0", "lyft"},
            {"52648E86-B617-44FD-B753-295D5CE9D9DC", "lyft_shared"},
            {"B47A0993-DE35-4F86-8DD8-C6462F16F5E8", "lyft_lux"},
            {"BB331ADE-E379-4F12-9AB0-A68AF94D5813", "lyft_suv"}
        };
    };
}
