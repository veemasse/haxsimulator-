using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandVpn : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public static bool vpn = false;

        public CommandVpn()
        {
            Name = "vpn";
            Command = "vpn";
            Description = "vpns the application";
            Help = "Use this command with no arguments to force Unity to vpn!";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
            Debug.Log("Vpn is activated");
            vpn = true;
        }


        

        public static CommandVpn CreateCommand()
        {
            return new CommandVpn();
        }
    }
}
