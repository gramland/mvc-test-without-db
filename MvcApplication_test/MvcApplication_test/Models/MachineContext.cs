using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcApplication_test.Models
{
     public class MachineContext
    {

        //public DbSet<Machines> Machines {get; set;}

    public List<Machines> listMachines = new List<Machines>
    {
        new Machines { id = 1, name = "machine one", description = "This is the machine number 1", status=1 },
        new Machines { id = 2, name = "machine two", description = "This is the machine number 2", status=0 },
        new Machines { id = 3, name = "machine three", description = "This is the machine number 3", status=1 },
        new Machines { id = 4, name = "machine four", description = "This is the machine number 4", status=0 },
        new Machines { id = 5, name = "machine five", description = "This is the machine number 5", status=0 },
        new Machines { id = 6, name = "machine six", description = "This is the machine number 6", status=0 },
        new Machines { id = 7, name = "machine seven", description = "This is the machine number 7", status=1 },
        new Machines { id = 8, name = "machine eight", description = "This is the machine number 8", status=1 },
        new Machines { id = 9, name = "machine nine", description = "This is the machine number 9", status=1 },
        new Machines { id = 10, name = "machine 10", description = "This is the machine number 10", status=1 }
        

    };

    public IQueryable<Machines> Machines
    {
        get { return Machines.AsQueryable(); }
    }

    }

    

}