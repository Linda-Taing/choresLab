using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoresLab.Models;
public class Chore
{
    public Chore(string name, int time, string location, int id)
    {
        Name = name;
        Time = time;
        Location = location;
        Id = Id;

    }

    public string Name { get; set; }
    public int Time { get; set; }
    public string Location { get; set; }
    public int Id { get; set; }
    public bool Completed { get; private set; } = false;
    public void IsFinished()
    {
        this.Completed = true;
    }

}
