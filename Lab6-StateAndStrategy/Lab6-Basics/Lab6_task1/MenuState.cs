using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_task1
{
    internal class MenuState : GameState
    {
        public MenuState(GameApp app) : base(app)
        {

        }

        public override void EnterButton()
        {
            Console.WriteLine("Starting game");
            parentApp.ChangeState(new DuringGame(parentApp));
        }

        public override void EscapeButton()
        {

        }

        public override void TabButton()
        {
            
        }

        public override void KeyboardInput(string s)
        {
            
        }
    }
}
