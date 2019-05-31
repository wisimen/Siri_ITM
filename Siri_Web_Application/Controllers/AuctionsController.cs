using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Siri_Web_Application.Models;

namespace Siri_Web_Application.Controllers
{
    public class AuctionsController : Controller
    {
        private Siri_Web_ApplicationContext db = new Siri_Web_ApplicationContext();

        // GET: Auctions
        public async Task<ActionResult> Index()
        {
            var auctions = db.Auctions.Include(a => a.Seller);
            return View(await auctions.ToListAsync());
        }

        // GET: Auctions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auction auction = await db.Auctions.FindAsync(id);
            if (auction == null)
            {
                return HttpNotFound();
            }
            return View(auction);
        }

        // GET: Auctions/Create
        public ActionResult Create()
        {
            ViewBag.SellerId = new SelectList(db.People, "IdPerson", "Name");
            return View();
        }

        // POST: Auctions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AuctionId,BasePrice,Location,StartDate,EndDate,SellerId")] Auction auction)
        {
            if (ModelState.IsValid)
            {
                db.Auctions.Add(auction);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SellerId = new SelectList(db.People, "IdPerson", "Name", auction.SellerId);
            return View(auction);
        }

        // GET: Auctions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auction auction = await db.Auctions.FindAsync(id);
            if (auction == null)
            {
                return HttpNotFound();
            }
            ViewBag.SellerId = new SelectList(db.People, "IdPerson", "Name", auction.SellerId);
            return View(auction);
        }

        // POST: Auctions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AuctionId,BasePrice,Location,StartDate,EndDate,SellerId")] Auction auction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auction).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SellerId = new SelectList(db.People, "IdPerson", "Name", auction.SellerId);
            return View(auction);
        }

        // GET: Auctions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auction auction = await db.Auctions.FindAsync(id);
            if (auction == null)
            {
                return HttpNotFound();
            }
            return View(auction);
        }

        // POST: Auctions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Auction auction = await db.Auctions.FindAsync(id);
            db.Auctions.Remove(auction);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
