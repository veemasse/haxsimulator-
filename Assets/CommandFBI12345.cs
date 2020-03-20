using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandFBI12345 : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public static bool FBI12345 = false;

        public CommandFBI12345()
        {
            Name = "fbi12345";
            Command = "fbi12345";
            Description = "salasana admin loginniin :D";
            Help = "salasana";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
            if (FBI12345 == false)
            {
            Debug.LogError("Command not recognized typing help might help you. Remember to use lower letters only");
            }
            if (FBI12345 == true)
            {
            Debug.Log("<color=green>You successfully hacked current target</color>");
            Debug.Log("<color=red>Boss: Good job</color>");
            }
        }
        //salasana

        public static CommandFBI12345 CreateCommand()
        {
            return new CommandFBI12345();
            
        }
    }
}
