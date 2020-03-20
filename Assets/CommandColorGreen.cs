using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandColorGreen : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public static bool colorgreen = false;

        public CommandColorGreen()
        {
            Name = "colorgreen";
            Command = "colorgreen";
            Description = "ColorGreens the application";
            Help = "Use this command with no arguments to force Unity to ColorGreen!";

            AddCommandToConsole();
        }
        
 
        public override void RunCommand()
        {
            Debug.Log("<color=green>You think you are already pro hacker? Complete first level to unlock this!</color>");
            colorgreen = true;        
        }
        

        public static CommandColorGreen CreateCommand()
        {
            return new CommandColorGreen();
        }
    } 
}
