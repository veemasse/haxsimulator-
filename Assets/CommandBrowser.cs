using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandBrowser : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandBrowser()
        {
            Name = "browser";
            Command = "browser";
            Description = "Browsers the application";
            Help = "Use this command with no arguments to force Unity to Browser!";

            AddCommandToConsole();
        }
        void Awake () {
        
        }
 

        public override void RunCommand()
        {
            Debug.Log("Valitettavasti komento ei toimi Browsertathan Browsernapista");
            SceneManager.LoadScene("Browser");
        }
        

        public static CommandBrowser CreateCommand()
        {
            return new CommandBrowser();
        }
    }
}
