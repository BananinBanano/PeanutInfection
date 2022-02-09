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
    }
}
