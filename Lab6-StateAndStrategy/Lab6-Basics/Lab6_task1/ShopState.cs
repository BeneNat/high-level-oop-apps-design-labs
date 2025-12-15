using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_task1
{
    internal class ShopState : GameState
    {
        public ShopState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("Opening chat");
            parentApp.ChangeState(new ChatState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("Close shop");
            parentApp.ChangeState(new DuringGame(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("Close chat");
            parentApp.ChangeState(new DuringGame(parentApp));
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine($"Looking for item: {s} ...");
        }
    }
}
