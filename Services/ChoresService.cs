using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoresLab.Services;
public class ChoresService
{
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    public List<Chore> GetAllChores()
    {
        return _repo.GetAllChores();
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal Chore GetOneChore(int id)
    {
        Chore chore = _repo.GetOneChore(id);
        {
            if (chore == null) throw new Exception($"No Chore with that id;{id}");
            return chore;
        }
    }
}