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
        dbChores.Add(new Chore("Vacuum", 15, "living room", 1));
        dbChores.Add(new Chore("Dishes", 15, "kitchen", 2));
        dbChores.Add(new Chore("Sweep", 30, "garage", 3));

    }

    internal Chore CreateChore(Chore choreData)
    {
        choreData.Id = dbChores[dbChores.Count - 1].Id + 1;
        dbChores.Add(new Chore(choreData.Name, choreData.Time, choreData.Location, choreData.Id));
        return choreData;
    }

    internal List<Chore> GetAllChores()
    {
        return dbChores;
    }

    internal Chore GetOneChore(int id)
    {
        Chore chore = dbChores.Find(chore => chore.Id == id);
        return chore;
    }


}
