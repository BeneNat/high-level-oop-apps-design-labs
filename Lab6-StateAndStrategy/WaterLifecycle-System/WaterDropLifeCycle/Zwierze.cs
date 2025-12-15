using System;

namespace WaterDropLifeCycle;

internal class Zwierze : DropState
{
    public Zwierze(WaterDrop drop) : base(drop)
    {
        
    }

    public override string Info()
    {
        return "Woda znajduje sie w zwierzeciu.";
    }
    
    public override void Opady() { parentDrop.Info();}

    public override void Oddychanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Zwierze oddycha.");
        parentDrop.ChangeState(new Chmura(parentDrop));
    }
    public override void Parowanie() { parentDrop.Info(); }
    public override void Picie() { parentDrop.Info(); }
    public override void Wplywa() { parentDrop.Info(); }

    public override void Wydalanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Zwierze wydala.");
        parentDrop.ChangeState(new Rzeka(parentDrop));
    }
    public override void Oczyszczanie() { parentDrop.Info(); }
}