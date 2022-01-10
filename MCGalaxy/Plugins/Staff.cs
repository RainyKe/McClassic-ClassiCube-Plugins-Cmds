/*
Discord - Gives you the discord server link
@author OtiMalia12
*/
using System;
using System.IO;

using MCGalaxy;
using MCGalaxy.Commands;

namespace MCGalaxy {

    public class DiscordPlugin : Plugin {
        public override string creator { get { return "OtiMalia12"; } }
        public override string MCGalaxy_Version { get { return "1.9.1.2"; } }
        public override string name { get { return "Discord"; } }

        public override void Load(bool startup) {
            Command.Register(new CmdDiscord());
        }

        public override void Unload(bool shutdown) {
            Command.Unregister(Command.Find("Discord"));
        }
    }

    public sealed class CmdDiscord : Command {
        public override string name { get { return "Discord"; } }
		public override string shortcut { get { return "Ds"; } }
        public override string type { get { return "information"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        public override void Use(Player p, string message) {
            p.Message("%SJoin the %adiscord%S server by clicking this link:");
			p.Message("%bhttps://discord.gg/gD7myXGXFw");
        }

        public override void Help(Player p)
		{
			p.Message("/Discord - Gives you the discord server link");
			p.Message("Shortcut - /Ds");
		}
    }
}
