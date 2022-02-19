using Exiled.API.Interfaces;
using System.ComponentModel;

namespace PeanutInfection
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("How many seconds before the player turns into SCP-173")]
        public float Delay { get; set; } = 2f;
        
        [Description("Enable broadcast when the player turns into SCP-173")]
        public bool Enablebc { get: set; } = true;
        
        [Description("Configurable BC")]
        public string Broadcast { get; set; } = "You have beenn infected by <color=#ff0000>SCP-173</color>!";
    }
}
