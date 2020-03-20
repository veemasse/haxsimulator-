using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandDelete : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandDelete()
        {
            Name = "delete";
            Command = "delete";
            Description = "deletes the application";
            Help = "Use this command with no arguments to force Unity to Delete!";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {
        Debug.Log("Things you are allowed to delete");
        Debug.Log("deletesys31");
        }
        

        public static CommandDelete CreateCommand()
        {
            return new CommandDelete();
        }
    }
}
