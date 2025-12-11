using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submarine;

internal class Scientist : Human
{
    private Equipment equipment;

    public Scientist(Equipment equipment)
    {
        this.equipment = equipment;
    }

    public void Work(double time)
    {
        for (int i = 0; i < time; i++)
        {
            if (i % 24 == 0) equipment.GatherData();
        }
    }
}