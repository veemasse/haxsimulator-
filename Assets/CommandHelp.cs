using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Console
{
    public class CommandHelp : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public CommandHelp()
        {
            Name = "help";
            Command = "help";
            Description = "Helps the application";
            Help = "Use this command with no arguments to force Unity to Help!";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
            
        Debug.Log("<color=green>ESC = PAUSE</color>");    
        Debug.Log("-----------Commands-----------");
        Debug.Log("<color=green>vpn - your public ip will be at japan</color>");
        Debug.Log("<color=green>bruteforce - forces to unlock password</color>");
        Debug.Log("<color=green>pause - maybe pauses the game</color>");
        Debug.Log("<color=green>pcupgrade - upgrades pc from potato</color>");
        Debug.Log("<color=green>hax - nasa admin login</color>");
        Debug.Log("<color=green>quit - quit</color>");
        Debug.Log("<color=green>restart - restarts the level</color>");
        Debug.Log("<color=green>menu - opens startmenu</color>");
        Debug.Log("<color=green>colorgreen - text will (maybe) change the text color</color>");
                
            
        }

        public static CommandHelp CreateCommand()
        {
            return new CommandHelp();
        }
    }
}