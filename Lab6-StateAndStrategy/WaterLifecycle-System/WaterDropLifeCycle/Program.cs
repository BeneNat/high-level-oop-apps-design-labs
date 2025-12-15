using System;

namespace WaterDropLifeCycle;

class Program
{
    static void Main()
    {
        WaterDrop kropla = new WaterDrop();

        for (int i = 0; i < 10; i++)
        {
            /*kropla.Opady();
            kropla.Oddychanie();
            kropla.Parowanie();
            kropla.Picie();
            kropla.Wplywa();
            kropla.Wydalanie();
            kropla.Oczyszczanie();*/
            kropla.Opady();
            kropla.Oddychanie();
            kropla.Opady();
            kropla.Picie();
            kropla.Wydalanie();
            kropla.Oczyszczanie();
            kropla.Parowanie();
            kropla.Oddychanie();
            kropla.Opady();
            kropla.Parowanie();
            kropla.Wplywa();
            kropla.Parowanie();
            kropla.Picie();
            kropla.Wydalanie();
            kropla.Oddychanie();
        }
        /*
        kropla.Opady();
        kropla.Oddychanie();
        kropla.Opady();
        kropla.Picie();
        kropla.Wydalanie();
        kropla.Oczyszczanie();
        kropla.Parowanie();
        kropla.Oddychanie();
        kropla.Opady();
        kropla.Parowanie();
        kropla.Wplywa();
        kropla.Parowanie();
        kropla.Picie();
        kropla.Wydalanie();
        kropla.Oddychanie();
        */
    }
}
