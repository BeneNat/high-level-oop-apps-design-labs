using System;

namespace WaterDropLifeCycle;

internal class Czlowiek : DropState
{
    public Czlowiek(WaterDrop drop) : base(drop)
    {
        
    }

    public override string Info()
    {
        return "Kropla zostala wchlonieta do organizmu czlowieka.";
    }
    
    public override void Opady() { parentDrop.Info(); }

    public override void Oddychanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Czlowiek sobie oddycha.");
        parentDrop.ChangeState(new Chmura(parentDrop));
    }
    public override void Parowanie() { parentDrop.Info(); }
    public override void Picie() { parentDrop.Info(); }
    public override void Wplywa() { parentDrop.Info(); }

    public override void Wydalanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Czlowiek wydala.");
        parentDrop.ChangeState(new Oczyszczalnia(parentDrop));
    }
    public override void Oczyszczanie() { parentDrop.Info(); }
}