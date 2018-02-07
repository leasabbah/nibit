using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationNibit.Controllers.Sevices;
using WebApplicationNibit.Models;

namespace WebApplicationNibit.Controllers
{
    public class BroadcastsController : Controller
    {
        private readonly IBroadcastsRepository _broadcastsRepository;
        // private BroadcastsList myAllBroadcasts;
        //private BroadcastsService _broadcastsService;
        // Use constructor injection for the dependencies
        public BroadcastsController(IBroadcastsRepository _broadcastsRepository)
        {
            this._broadcastsRepository = _broadcastsRepository;
           // _broadcastsService = new BroadcastsService();
           // myAllBroadcasts = _broadcastsService.getAllBroadcasts();
        }
        
        private List<Broadcast> broadcastsList;

        // GET: Broadcasts/BView
        //return a brodcastsList object
        public ActionResult BView()
        {          
            return View(this._broadcastsRepository.getAllBroadcasts());
        }
        // GET: Broadcasts/BroadcastsDetails
        //return an broadcast object
        public ActionResult BroadcastDetails(int id)
        {
            broadcastsList = this._broadcastsRepository.getAllBroadcasts().Broadcasts;
            foreach (Broadcast b in broadcastsList)
            {
                if (b.BroadcastId == id)
                    return View(new Broadcast (b));

            }
            return HttpNotFound();
            //var selectedbroadcast =
            // new Broadcast
            // {
            //     BroadcastDate = DateTime.Now,
            //     BroadcastId = 123,
            //     BroadcastType = "items",
            //     DataAmount = 500,
            //     fileName = "items.txt",
            //     sentBy = "xxx"
            // };

            //return View(selectedbroadcast);
        }
    }
}