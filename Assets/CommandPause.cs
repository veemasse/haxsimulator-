using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandPause : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public static bool pausecommand = false;
        public CommandPause()
        {
            Name = "pause";
            Command = "pause";
            Description = "Pauses the application";
            Help = "Use this command with no arguments to force Unity to Pause!";

            AddCommandToConsole();
        }
        private void Start() {
        var arlet = GameObject.Find ("arlet");    
        }
        public override void RunCommand()
        {
            Debug.LogError("<color=green>Not sure if this works (maybe you broke something)</color>");
            var arlet = GameObject.Find ("arlet");
            arlet.SetActive(false);
        }
        

        public static CommandPause CreateCommand()
        {
            return new CommandPause();
        }
    }
}
