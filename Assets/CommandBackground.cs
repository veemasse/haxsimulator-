using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandBackground : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandBackground()
        {
            Name = "background";
            Command = "background";
            Description = "Backgrounds the application";
            Help = "Use this command with no arguments to force Unity to Background!";

            AddCommandToConsole();
        }
        void Awake () {
        
        }
 

        public override void RunCommand()
        {
            SceneManager.LoadScene("Background");
        }
        

        public static CommandBackground CreateCommand()
        {
            return new CommandBackground();
        }
    }
}
