namespace Lab6_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameApp app = new GameApp();
            app.EnterButton();
            app.EnterButton();
            app.KeyboardInput("string");
            app.EnterButton();
            app.TabButton();
            app.KeyboardInput("sword");
        }
    }
}
