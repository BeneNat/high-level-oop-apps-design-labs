using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_task1
{
    internal class DuringGame : GameState
    {
        public DuringGame(GameApp app) : base(app)
        {

        }

        public override void EnterButton()
        {
            parentApp.ChangeState(new ChatState(parentApp));
        }

        public override void EscapeButton()
        {
            parentApp.ChangeState(new MenuState(parentApp));
        }

        public override void TabButton()
        {
            parentApp.ChangeState(new ShopState(parentApp));
        }

        public override void KeyboardInput(string s)
        {
            
        }
    }
}
