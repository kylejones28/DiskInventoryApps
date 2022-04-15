using System.Linq;
using System.Threading.Tasks;
using DiskInventoryApps.Models;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace DiskInventoryApps.Controllers
{
    public class DiskController : Controller
    {
        private disk_inventorykjContext context { get; set; }
        public DiskController(disk_inventorykjContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            List<Disk> disk = context.Disks.OrderBy(b => b.DiskName).ThenBy(b => b.DiskTypeId).ToList();
            return View(disk);
        }
    }
}
