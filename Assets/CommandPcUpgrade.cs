    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandPcUpgrade : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public static bool pcupgrade = false;

        public CommandPcUpgrade()
        {
            Name = "pcupgrade";
            Command = "pcupgrade";
            Description = "pcupgrades the application";
            Help = "Use this command with no arguments to force Unity to pcupgrade!";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
            Debug.Log("Your pc is upgraded from potato!");
            pcupgrade = true;
        }
        

        public static CommandPcUpgrade CreateCommand()
        {
            return new CommandPcUpgrade();
            
        }
    }
}
