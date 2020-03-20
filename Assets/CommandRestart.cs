using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Console
{
    public class CommandRestart : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandRestart()
        {
            Name = "restart";
            Command = "restart";
            Description = "Restarts the game";
            Help = "restarts the level";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
            SceneManager.LoadScene("local");
        }
        public static CommandRestart CreateCommand()
        {
            return new CommandRestart();
        }
    }
}