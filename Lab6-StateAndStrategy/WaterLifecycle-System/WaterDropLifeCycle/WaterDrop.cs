using System;

namespace WaterDropLifeCycle;

internal class WaterDrop
{
    private DropState currentState;

    public WaterDrop()
    {
        currentState = new Chmura(this);
    }

    public void ChangeState(DropState newState)
    {
        currentState = newState;
    }

    public void Info()
    {
        Console.WriteLine(currentState.Info());
    }

    public void Oddychanie()
    {
        currentState.Oddychanie();
    }

    public void Opady()
    {
        currentState.Opady();
    }

    public void Parowanie()
    {
        currentState.Parowanie();
    }

    public void Picie()
    {
        currentState.Picie();
    }

    public void Wplywa()
    {
        currentState.Wplywa();
    }

    public void Wydalanie()
    {
        currentState.Wydalanie();
    }

    public void Oczyszczanie()
    {
        currentState.Oczyszczanie();
    }
}