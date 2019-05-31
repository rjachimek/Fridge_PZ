using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FridgePZ.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace FridgePZ.Controllers
{
    public class ItemsController : Controller
    {
        private readonly fridgepzContext _context;

        public ItemsController(fridgepzContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            List<Item> fridgepzContext = returnUserItems();
            return View(fridgepzContext);

        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }

        public User returnUser()
        {
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User user = query.Single();
            return user;
        }


        public async Task<IActionResult> Status()
        {
            try
            {
                checkExpirationDate();
                checkAwarenessDate();
                
                
                User cur_user = returnUser();
                var query1 = from itempattern in _context.Itempattern
                    join item in _context.Item on itempattern.ItemPatternId equals item.ItemPatternId
                    join shelf in _context.Shelf on item.ShelfId equals shelf.ShelfId
                    join storage in _context.Storage on shelf.StorageId equals storage.StorageId
                    join privelege in _context.Privilege on storage.StorageId equals privelege.StorageId
                    join user in _context.User on privelege.UserId equals user.UserId
                    where user == cur_user && item.NotificationId == 1
                            select item;


                List<Item> not1 = query1.ToList();

                return View(not1);
            }
            catch (Exception e)
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateNabial()
        {
            var itempattern = from _i in _context.Itempattern
                              where _i.CategoryItemPatternId == 1
                              select _i;

            return View(await itempattern.ToListAsync());
        }

        public async Task<IActionResult> CreatePieczywo()
        {
            var itempattern = from _i in _context.Itempattern
                              where _i.CategoryItemPatternId == 4
                              select _i;

            return View(await itempattern.ToListAsync());
        }

        public async Task<IActionResult> CreateItem(int? id)
        {
            if(returnUser() == null) { return RedirectToAction("Login", "Account"); }
            Itempattern _i = await _context.Itempattern.FindAsync(id);
            List<Shelf> _s = returnUserShelfs();
            if (_s.Last() == null) { return RedirectToAction(nameof(Index)); }
            Item item = new Item();
            item.ItemPatternId = id??default;
            DateTime itemTime = DateTime.Now;
            decimal days = Convert.ToDecimal(_i.LongLife);
            double elapsed = (double)days;
            itemTime = itemTime.AddDays(elapsed);
            item.ExpirationDate = itemTime;
            item.NotificationId = null;
            item.HowMuchLeft = _i.Size;
            item.ShelfId = _s.First().ShelfId;
            item.IsOpen = 0;
            _context.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Decrease(int? id)
        {
            decreasePortion(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            Item cur_item = _context.Item.Find(id);
            var _item = await _context.Item.FindAsync(cur_item.ItemId);
            _context.Item.Remove(_item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async void decreasePortion(int? id)
        {
            Item cur_item = _context.Item.Find(id);
            Itempattern pat = await _context.Itempattern.FindAsync(cur_item.ItemPatternId);
            if (cur_item.HowMuchLeft - 125 >= 0)
            {
                cur_item.HowMuchLeft -= 125;
                if (cur_item.HowMuchLeft == 0)
                {
                    var _item = await _context.Item.FindAsync(cur_item.ItemId);
                    _context.Item.Remove(_item);
                }
                await _context.SaveChangesAsync();
            }
            else
            {
                var _item = await _context.Item.FindAsync(cur_item.ItemId);
                _context.Item.Remove(_item);
                await _context.SaveChangesAsync();
            }
        }

        public List<Item> returnUserItems()
        {
            User cur_user = returnUser();
            var query = from _item in _context.Item
                        join _shelf in _context.Shelf on _item.ShelfId equals _shelf.ShelfId
                        join _storage in _context.Storage on _shelf.StorageId equals _storage.StorageId
                        join _privilege in _context.Privilege on _storage.StorageId equals _privilege.StorageId
                        join _user in _context.User on _privilege.UserId equals _user.UserId
                        where cur_user.UserId == _user.UserId
                        select _item;
            List<Item> item = query.ToList();
            return item;
        }

        public List<Shelf> returnUserShelfs()
        {
            User cur_user = returnUser();
            var query = from _shelf in _context.Shelf
                        join _storage in _context.Storage on _shelf.StorageId equals _storage.StorageId
                        join _privilege in _context.Privilege on _storage.StorageId equals _privilege.StorageId
                        join _user in _context.User on _privilege.UserId equals _user.UserId
                        where cur_user.UserId == _user.UserId
                        select _shelf;
            List<Shelf> shelf = query.ToList();
            return shelf;
        }

        public List<Item> returnItems()
        {
            var query = from _item in _context.Item
                        join _itempattern in _context.Itempattern
                        on _item.ItemPatternId equals _itempattern.ItemPatternId
                        select _item;
            List<Item> item = query.ToList();
            return item;
        }
        public void checkExpirationDate()
        {
            string constr = "Server=fridge-database.mysql.database.azure.com;Port=3306;Database=fridgepz;Uid=PZadmin@fridge-database;Pwd=Qwerty1!;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("chceckExpirationDate", con))
                {
                    List<Item> item = returnItems();
                    User user = returnUser();

                    foreach (Item _item in item)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("itemIdT", _item.ItemId);
                        cmd.Parameters.AddWithValue("loginUser", user.Login);
                        cmd.Connection.Open();
                        var result = cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        cmd.Parameters.Clear();//<--clear all the parameters.
                    }
                }
            }
        }

        public void checkAwarenessDate()
        {
            string constr = "Server=fridge-database.mysql.database.azure.com;Port=3306;Database=fridgepz;Uid=PZadmin@fridge-database;Pwd=Qwerty1!;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("checkProductAttention", con))
                {
                    List<Item> item = returnItems();
                    User user = returnUser();

                    foreach (Item _item in item)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("itemIdT", _item.ItemId);
                        cmd.Parameters.AddWithValue("loginUser", user.Login);
                        cmd.Connection.Open();
                        var result = cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        cmd.Parameters.Clear();//<--clear all the parameters.
                    }
                }
            }
        }


        public async Task<IActionResult> Decrease(int? id)
        {
            decreasePortion(id);
            return RedirectToAction(nameof(Index));
        }


        public async void decreasePortion(int? id)
        {
            Item cur_item = _context.Item.Find(id);
            Itempattern pat = await _context.Itempattern.FindAsync(cur_item.ItemPatternId);
            if (cur_item.HowMuchLeft - 125 >= 0)
            {
                cur_item.HowMuchLeft -= 125;
                if(cur_item.HowMuchLeft == 0)
                {
                    var _item = await _context.Item.FindAsync(cur_item.ItemId);
                    _context.Item.Remove(_item);
                }
                await _context.SaveChangesAsync();
            }
            else
            {
                var _item = await _context.Item.FindAsync(cur_item.ItemId);
                _context.Item.Remove(_item);
                await _context.SaveChangesAsync();
            }
          
        }


        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {

                String email = User.Identity.Name;
                fridgepzContext db = new fridgepzContext();
                var query = from p in db.User where p.Email.Equals(email) select p;
                User user = query.Single();
                ViewData["ItemPatternId"] = new SelectList(_context.Itempattern, "ItemPatternId", "ItemPatternId");
                ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type");
                ViewData["ShelfId"] = new SelectList(_context.Shelf, "ShelfId", "Name");

            }

            return View();
        }

        // POST: Items1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,ShelfId,ItemPatternId,NotificationId,HowMuchLeft,ExpirationDate,IsOpen")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemPatternId"] = new SelectList(_context.Itempattern, "ItemPatternId", "ItemPatternId", item.ItemPatternId);
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type", item.NotificationId);
            ViewData["ShelfId"] = new SelectList(_context.Shelf, "ShelfId", "Name", item.ShelfId);
            return View(item);
        }

        // GET: Items1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["ItemPatternId"] = new SelectList(_context.Itempattern, "ItemPatternId", "ItemPatternId", item.ItemPatternId);
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type", item.NotificationId);
            ViewData["ShelfId"] = new SelectList(_context.Shelf, "ShelfId", "Name", item.ShelfId);
            return View(item);
        }

        // POST: Items1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,ShelfId,ItemPatternId,NotificationId,HowMuchLeft,ExpirationDate,IsOpen")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemPatternId"] = new SelectList(_context.Itempattern, "ItemPatternId", "ItemPatternId", item.ItemPatternId);
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type", item.NotificationId);
            ViewData["ShelfId"] = new SelectList(_context.Shelf, "ShelfId", "Name", item.ShelfId);
            return View(item);
        }

        // GET: Items1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .Include(i => i.ItemPattern)
                .Include(i => i.Notification)
                .Include(i => i.Shelf)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }


}

