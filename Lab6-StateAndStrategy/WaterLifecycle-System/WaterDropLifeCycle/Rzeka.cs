using System;

namespace WaterDropLifeCycle;

internal class Rzeka : DropState
{
    public Rzeka(WaterDrop drop) : base(drop)
    {
        
    }

    public override string Info()
    {
        return "Kropla trafila do rzeki.";
    }
    
    public override void Opady() { parentDrop.Info(); }
    public override void Oddychanie() { parentDrop.Info(); }

    public override void Parowanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Woda paruje z rzeki.");
        parentDrop.ChangeState(new Chmura(parentDrop));
    }

    public override void Picie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Zwierze pije wode z rzeki.");
        parentDrop.ChangeState(new Zwierze(parentDrop));
    }

    public override void Wplywa()
    {
        parentDrop.Info();
        Console.WriteLine("-> Rzeka laczy sie z oceanem.");
        parentDrop.ChangeState(new Ocean(parentDrop));
    }
    public override void Wydalanie() { parentDrop.Info(); }
    public override void Oczyszczanie() { parentDrop.Info(); }
}