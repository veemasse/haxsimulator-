using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Console
{
    public abstract class ConsoleCommand
    {
        
        public abstract string Name { get; protected set; }
        public abstract string Command { get; protected set; }
        public abstract string Description { get; protected set; }
        public abstract string Help { get; protected set; }

        public void AddCommandToConsole()
        {
            //string addMessage = "command has been added to the console.";

            DeveloperConsole.AddCommandsToConsole(Command, this);
            //Debug.Log(Name + addMessage);
        }
        

        public abstract void RunCommand();
    }

    public class DeveloperConsole : MonoBehaviour
    {
        public static DeveloperConsole Instance { get; private set; }
        public static Dictionary<string, ConsoleCommand> Commands { get; private set; }

        [Header("UI Components")]
        public Canvas consoleCanvas;
        public Text consoleText;
        public Text inputText;
        public InputField consoleInput;
        public static bool levelpass = false;
        private void Awake()
        {
            if(Instance != null)
            {
                return;
            }

            Instance = this;
            Commands = new Dictionary<string, ConsoleCommand>();
        }

        private void Start()
        {
            consoleCanvas.gameObject.SetActive(true);
            CreateCommands();
            Debug.Log("<color=red>Boss: Welcome to the operation</color>");
            Debug.Log("<color=red>Boss: Your mission is to hack nasa</color>");
            Debug.Log("<color=red>Boss: This command prompt is only tool you can use</color>");
        }

        private void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        private void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
        }

        private void HandleLog(string logMessage, string stackTrace, LogType type)
        {
            string _message = "[" + type.ToString() + "] " + logMessage;
            AddMessageToConsole(_message);
        }

        private void CreateCommands()
        {
            CommandQuit.CreateCommand();
            CommandRestart.CreateCommand();
            CommandMenu.CreateCommand();
            CommandHelp.CreateCommand();
            CommandHax.CreateCommand();
            CommandVpn.CreateCommand();
            CommandBruteForce.CreateCommand();
            CommandPcUpgrade.CreateCommand();
            CommandBrowser.CreateCommand();
            CommandColorGreen.CreateCommand();
            CommandBackGroundHax.CreateCommand();
            CommandFBI12345.CreateCommand();
            CommandPause.CreateCommand();
        }

        public static void AddCommandsToConsole(string _name, ConsoleCommand _command)
        {
            if(!Commands.ContainsKey(_name))
            {
                Commands.Add(_name, _command);
            }
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.BackQuote))
            {
                consoleCanvas.gameObject.SetActive(!consoleCanvas.gameObject.activeInHierarchy);
            }
            if(consoleCanvas.gameObject.activeInHierarchy)
            {
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    if(inputText.text != "")
                    {
                        AddMessageToConsole(inputText.text);
                        ParseInput(inputText.text);
                    }            
                }
            }
        }

        private void AddMessageToConsole(string msg)
        {
            consoleText.text += msg + "\n";
        }

        private void ParseInput(string input)
        {
            string[] _input = input.Split(null);

            if (_input.Length == 0 || _input == null)
            {
                Debug.LogError("Command not recognized typing help might help you. Remember to use lower letters only");
                return;
            }

            if (!Commands.ContainsKey(_input[0]))
            {
                Debug.LogError("Command not recognized command help might help you. Remember to use lower letters only");
            }
            else
            {
                Commands[_input[0]].RunCommand();
            }
            if (CommandColorGreen.colorgreen == true)
            {
            
            }
        }
    }
}
