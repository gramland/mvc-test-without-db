using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_test.Models;



namespace MvcApplication_test.Controllers
{
    public class MachinesController : Controller
    {
        //
        // GET: /Machines/

        public ActionResult Index()
        {
            //MachineContext machineContext = new MachineContext();
            List<Machines> allmachines = MachineContext.listMachines;
            return View(allmachines);
        }


        public ActionResult Details(int id)
        {
            //MachineContext machineContext = new MachineContext();
            Machines machine = MachineContext.listMachines.Single(mac => mac.id == id);

            


            return View(machine);
        }

    }
}
