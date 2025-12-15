using System;

namespace WaterDropLifeCycle;

internal class Ocean : DropState
{
    public Ocean(WaterDrop drop) : base(drop)
    {
        
    }

    public override string Info()
    {
        return "Kropla trafila do oceanu.";
    }
    
    public override void Opady() { parentDrop.Info(); }
    public override void Oddychanie() { parentDrop.Info(); }

    public override void Parowanie()
    {
        parentDrop.Info();
        Console.WriteLine("Woda paruje z oceanu.");
        parentDrop.ChangeState(new Chmura(parentDrop));
    }
    public override void Picie() { parentDrop.Info(); }
    public override void Wplywa() { parentDrop.Info(); }
    public override void Wydalanie() { parentDrop.Info(); }
    public override void Oczyszczanie() { parentDrop.Info(); }
}