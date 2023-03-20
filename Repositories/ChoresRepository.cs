using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChoresLab.Models;

namespace ChoresLab.Repositories;

public class ChoresRepository
{
    private List<Chore> dbChores = new List<Chore>();

    public ChoresRepository()
    {
        dbChores.Add(new Chore("Vacuum", 15, "living room"));
        dbChores.Add(new Chore("Dishes", 15, "kitchen"));
        dbChores.Add(new Chore("Sweep", 30, "garage"));

    }
}
