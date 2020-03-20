using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandColor : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandColor()
        {
            Name = "color";
            Command = "color";
            Description = "Colors the application";
            Help = "Use this command with no arguments to force Unity to Color!";

            AddCommandToConsole();
        }
        public override void RunCommand()
        {
            Debug.Log("Commands for color.");
            Debug.Log("colorgreen");
        }
        

        public static CommandColor CreateCommand()
        {
            return new CommandColor();
        }
    }
}
