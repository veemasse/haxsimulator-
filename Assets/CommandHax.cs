using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Console
{
    
    public class CommandHax : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public CommandHax()
        {
            Name = "hax";
            Command = "hax";
            Description = "Haxs the application";
            Help = "Use this command with no arguments to force Unity to Hax!";

            AddCommandToConsole();
        }
        
        public override void RunCommand()
        {
            
            {
                Debug.Log ("Entering nasa admin login...");
            }
            if (CommandVpn.vpn == false)
            {
                Debug.Log("*fbi knocking on your door*");
                SceneManager.LoadScene("LevelFail");
            }
            else
            {
                Debug.Log("Enter password");
            }
        }
        

        public static CommandHax CreateCommand()
        {
            return new CommandHax();
        }
    }
}
