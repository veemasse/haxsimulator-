using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Console
{
    public class CommandMenu : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandMenu()
        {
            Name = "menu";
            Command = "menu";
            Description = "menus the application";
            Help = "Use this command with no arguments to force Unity to menu!";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
            SceneManager.LoadScene("StartMenu");
        }

        public static CommandMenu CreateCommand()
        {
            return new CommandMenu();
        }
    }
}