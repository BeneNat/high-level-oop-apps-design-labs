namespace WaterDropLifeCycle;

internal abstract class DropState
{
    protected WaterDrop parentDrop;

    public DropState(WaterDrop drop)
    {
        parentDrop = drop;
    }
    
    public abstract string Info();

    public abstract void Oddychanie();
    public abstract void Opady();
    public abstract void Parowanie();
    public abstract void Picie();
    public abstract void Wplywa();
    public abstract void Wydalanie();
    public abstract void Oczyszczanie();
}