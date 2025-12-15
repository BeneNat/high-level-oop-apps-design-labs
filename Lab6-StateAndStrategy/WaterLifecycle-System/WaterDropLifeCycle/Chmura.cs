using System;

namespace WaterDropLifeCycle;

internal class Chmura : DropState
{
    private static Random rand = new Random();
    
    public Chmura(WaterDrop drop) : base(drop)
    {
        
    }

    public override string Info()
    {
        return "Kropla znajduje sie w chmurze.";
    }

    public override void Opady()
    {
        parentDrop.Info();
        
        int los = rand.Next(3);
        switch (los)
        {
            case 0:
                Console.WriteLine("-> Kropla trafia do rośliny.");
                parentDrop.ChangeState(new Roslina(parentDrop));
                break;
            case 1:
                Console.WriteLine("-> Kropla splywa do rzeki.");
                parentDrop.ChangeState(new Rzeka(parentDrop));
                break;
            case 2:
                Console.WriteLine("-> Kropla trafia do studni.");
                parentDrop.ChangeState(new Studnia(parentDrop));
                break;
        }
    }
    public override void Oddychanie() { parentDrop.Info(); }
    public override void Parowanie() { parentDrop.Info(); }
    public override void Picie() { parentDrop.Info(); }
    public override void Wplywa() { parentDrop.Info(); }
    public override void Wydalanie() { parentDrop.Info(); }
    public override void Oczyszczanie() { parentDrop.Info(); }
}