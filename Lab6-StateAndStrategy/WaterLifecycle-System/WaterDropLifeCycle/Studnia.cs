using System;

namespace WaterDropLifeCycle;

internal class Studnia : DropState
{
    public Studnia(WaterDrop drop) : base(drop)
    {
        
    }
    public override string Info()
    {
        return "Kropla znajduje sie w studni.";
    }

    public override void Opady() { parentDrop.Info(); }
    public override void Oddychanie() { parentDrop.Info(); }
    public override void Parowanie() { parentDrop.Info(); }

    public override void Picie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Czlowiek pije wode ze studni.");
        parentDrop.ChangeState(new Czlowiek(parentDrop));
    }
    public override void Wplywa() { parentDrop.Info(); }
    public override void Wydalanie() { parentDrop.Info(); }
    public override void Oczyszczanie() { parentDrop.Info(); }
}