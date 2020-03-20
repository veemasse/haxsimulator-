using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Console
{
    public class CommandBackGroundHax : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public Sprite Sprite1UI;
        
        public CommandBackGroundHax()
        {
            Name = "backgroundhax";
            Command = "backgroundhax";
            Description = "Changes background :D";
            Help = "";

            AddCommandToConsole();
        }

        public override void RunCommand()
        {

        }

        public static CommandBackGroundHax CreateCommand()
        {
            return new CommandBackGroundHax();
        }
    }
}