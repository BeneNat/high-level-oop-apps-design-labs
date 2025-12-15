using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_task1
{
    internal class ChatState : GameState
    {
        public ChatState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("Closing chat");
            parentApp.ChangeState(new DuringGame(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Closing chat");
            parentApp.ChangeState(new DuringGame(parentApp));
        }

        public override void TabButton()
        {
            
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine($"Display some info: {s}");
        }
    }
}
