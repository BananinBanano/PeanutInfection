using System;
using Exiled.API.Features;

namespace PeanutInfection
{
    public class Main : Plugin<Config>
    {
        public static Main singleton;

        public override string Author { get; } = "BANANO";
        public override string Name { get; } = "PeanutInfection";
        public override string Prefix { get; } = "Peanut Infection";
        public override Version Version { get; } = new Version(0, 2, 0);
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 3);

        public EventHandlers _handler;
        public override void OnEnabled()
        {
            singleton = this;
            _handler = new EventHandlers();

            Exiled.Events.Handlers.Player.Dying += _handler.OnDying;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Dying -= _handler.OnDying;

            singleton = null;
            _handler = null;
            base.OnDisabled();
        }
    }
}
