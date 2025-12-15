using System;

namespace WaterDropLifeCycle;

internal class Roslina : DropState
{
    public Roslina(WaterDrop drop) : base(drop)
    {
        
    }
    
    public override string Info()
    {
        return "Kropla zostala wchlonieta przez rosline.";
    }
    
    public override void Opady() { parentDrop.Info(); }

    public override void Oddychanie()
    {
        parentDrop.Info();
        Console.WriteLine("-> Roslina oddycha.");
        parentDrop.ChangeState(new Chmura(parentDrop));
    }
    public override void Parowanie() { parentDrop.Info(); }
    public override void Picie() { parentDrop.Info(); }
    public override void Wplywa() { parentDrop.Info(); }
    public override void Wydalanie() { parentDrop.Info(); }
    public override void Oczyszczanie() { parentDrop.Info(); }
}