using System;

namespace WaterDropLifeCycle;

internal class Oczyszczalnia : DropState
{
    public Oczyszczalnia(WaterDrop drop) : base(drop)
    {
        
    }

    public override string Info()
    {
        return "Kropla trafila do oczyszczalni.";
    }
    
    public override void Opady() { parentDrop.Info(); }
    public override void Oddychanie() { parentDrop.Info(); }
    public override void Parowanie() { parentDrop.Info(); }
    public override void Picie() { parentDrop.Info(); }
    public override void Wplywa() { parentDrop.Info(); }
    public override void Wydalanie() { parentDrop.Info(); }

    public override void Oczyszczanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Woda jest oczyszczana.");
        parentDrop.ChangeState(new Rzeka(parentDrop));
    }
}