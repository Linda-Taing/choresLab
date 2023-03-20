using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choresLab.Models;
    public class Chore
{
        public Chore(string name, int time, string location)
        {
            Name = name;
            Time = time;
            Location = location;
        }

        public string Name {get; set; }
        public int Time {get; set;}
        public string Location {get; set;}
        public bool Completed {get; private set;} = false;
        public void IsFinished()
        {
            this.Completed = true;
        }

    }
