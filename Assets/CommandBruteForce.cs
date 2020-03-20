using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Console
{
    
    public class CommandBruteForce : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public static bool bruteforce = false;



        

        public CommandBruteForce()
        {
            Name = "bruteforce";
            Command = "bruteforce";
            Description = "bruteforces the application";
            Help = "Use this command with no arguments to force Unity to BruteForce!";

            AddCommandToConsole();
        }
        void Update() 
        {
   
        }
        void time()
        {

        }

        public override void RunCommand()
        {
            
            if (CommandPcUpgrade.pcupgrade == false)
            {
                Debug.Log("bruteforcing...");
          

                Debug.Log("*<color=red>PC exploded</color>");
                SceneManager.LoadScene("LevelFail");
            }
            else 
            {
                Debug.Log("bruteforcing");
                Debug.Log("Password: <color=green>fbi12345</color>");
                bruteforce = true;
            }
        }
        

        public static CommandBruteForce CreateCommand()
        {
            return new CommandBruteForce();
        }
    }
}
