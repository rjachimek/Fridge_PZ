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
    /// <summary>
    /// Klasa do kontroli produktów użytkownika w lodówce
    /// </summary>
    public class ItemsController : Controller
    {
        private readonly fridgepzContext _context;

        public ItemsController(fridgepzContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Funkcja zwracająca widok ze wszystkimi produktami należącymi do zalogowanego użytkownika
        /// </summary>
        public async Task<IActionResult> Index()
        {
            try
            {
                List<Item> fridgepzContext = returnUserItems();
                return View(fridgepzContext);
            }
            catch (Exception e)
            {
                return RedirectToAction("Login", "Account");
            }
        }

        /// <summary>
        /// Sprawdza czy produkt o danym kluczu istnieje w bazie
        /// </summary>
        /// <param name="id">Identyfikator produktu w bazie</param>
        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }

        /// <summary>
        /// Zwraca użytkownika zalogowanego teraz
        /// </summary>
        /// <returns>
        /// Zalogowany user
        /// </returns>
        /// <exception cref="System.NullReferenceException"> Zwraca kiedy nie ma zalogowanego usera </exception>
        public User returnUser()
        {
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User user = query.Single();
            return user;
        }

        /// <summary>
        /// Sprawdza czy dany użytkownik ma przeterminowane albo bliskie przeterminowania produty
        /// </summary>
        /// <returns>
        /// Widok ekranu statusowego
        /// </returns>
        /// <exception cref="System.NullReferenceException"> Zwraca kiedy nie ma zalogowanego usera </exception>
        public async Task<IActionResult> Status()
        {
            try
            {
                ///<remarks>
                ///Fukncje sprawdzające status produktów w bazie
                /// </remarks>
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

        /// <summary>
        /// Ekran dodawania produktów do bazy na podstawie kafelków z kategoriami produktów
        /// </summary>
        /// <returns>Widok dodawania produktów</returns>
        public async Task<IActionResult> Create()
        {
            return View();
        }

        /// <summary>
        /// Ekran dodawania produktów do bazy na podstawie kafelków z nabiałem
        /// </summary>
        /// <returns>Widok dodawania produktów nabiału</returns>
        public async Task<IActionResult> CreateNabial()
        {
            ///<remarks>
            /// Pobieranie wszystkich produktów dostępnych w bazie
            /// </remarks>
            var itempattern = from _i in _context.Itempattern
                              where _i.CategoryItemPatternId == 1
                              select _i;

            return View(await itempattern.ToListAsync());
        }

        /// <summary>
        /// Ekran dodawania produktów do bazy na podstawie kafelków z pieczywem
        /// </summary>
        /// <returns>Widok dodawania produktów</returns>
        public async Task<IActionResult> CreatePieczywo()
        {
            ///<remarks>
            /// Pobieranie wszystkich produktów dostępnych w bazie
            ///</remarks>
            var itempattern = from _i in _context.Itempattern
                              where _i.CategoryItemPatternId == 4
                              select _i;

            return View(await itempattern.ToListAsync());
        }

        /// <summary>
        /// Funkcja dodawania produktu na bazie wynikająca z wyklikania pruktu w kafelkach
        /// Jeśli użytkownik nie jest zalogowany to jest przekierowywany do ekranu logowania
        /// </summary>
        /// <param name="id">Identyfikator wybranego produktu w bazie</param>
        /// <returns>Widok wszystkich produktów</returns>
        public async Task<IActionResult> CreateItem(int? id)
        {
            if (returnUser() == null) { return RedirectToAction("Login", "Account"); }
            Itempattern _i = await _context.Itempattern.FindAsync(id);

            /// <remarks>
            /// Pobieramy wszystkie półki użytkownika
            /// </remarks>
            List<Shelf> _s = returnUserShelfs();
            /// <remarks>
            /// Jeśli półek nie ma to przekierowujemy użytkownika do Przedmiotów
            /// </remarks>
            if (_s.Last() == null) { return RedirectToAction(nameof(Index)); }
            /// <remarks>
            /// Tworzymy przedmiot na podstawie kafelka wyklikanego
            /// </remarks>
            Item item = new Item();
            item.ItemPatternId = id ?? default;
            DateTime itemTime = DateTime.Now;
            decimal days = Convert.ToDecimal(_i.LongLife);
            double elapsed = (double)days;
            itemTime = itemTime.AddDays(elapsed);
            item.ExpirationDate = itemTime;
            item.NotificationId = null;
            item.HowMuchLeft = _i.Size;
            item.ShelfId = _s.First().ShelfId;
            item.IsOpen = 0;
            /// <remarks>
            /// Dodajemy produkt do bazy
            /// </remarks>
            _context.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Odejmowanie porcji produktu użytkownika
        /// </summary>
        /// <param name="id">Identyfikator wybranego produktu w bazie</param>
        /// <returns>Widok wszystkich produktów</returns>
        public async Task<IActionResult> Decrease(int? id)
        {
            decreasePortion(id);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Usuwanie produktu użytkownika
        /// </summary>
        /// <param name="id">Identyfikator wybranego produktu w bazie</param>
        /// <returns>Widok wszystkich produktów</returns>
        /// <exception cref="System.NullReferenceException"> Zwraca kiedy nie ma zalogowanego usera </exception>
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                User cur_user = returnUser();
                Item cur_item = _context.Item.Find(id);
                var _item = await _context.Item.FindAsync(cur_item.ItemId);
                _context.Item.Remove(_item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return RedirectToAction("Login", "Account");
            }
        }

        /// <summary>
        /// Funkcja usuwania porcji produktu
        /// </summary>
        /// <param name="id">Identyfikator wybranego produktu w bazie</param>
        /// <remarks>
        /// Odejmuje 126 g/ml produktu jeśli produkt posiada tyle
        /// Jeśli nie to usuwa go z bazy
        /// </remarks>
        /// 
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

        /// <summary>
        /// Zwraca wszystkie produkty użytkownika
        /// </summary>
        /// <returns>Wszystkie przedmioty należące do danego użytkownika</returns>
        /// <exception cref="System.NullReferenceException"> Zwraca kiedy nie ma zalogowanego usera </exception>
        public List<Item> returnUserItems()
        {
            try
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
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Zwraca wszystkie półki użytkownika
        /// </summary>
        /// <returns>Wszystkie półki należące do danego użytkownika</returns>
        /// <exception cref="System.NullReferenceException"> Zwraca kiedy nie ma zalogowanego usera </exception>
        public List<Shelf> returnUserShelfs()
        {
            try
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
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Zwraca wszystkie produkty użytkownika
        /// </summary>
        /// <returns>Wszystkie produkty należące do danego użytkownika</returns>
        /// <exception cref="System.NullReferenceException"> Zwraca kiedy nie ma zalogowanego usera </exception>
        public List<Item> returnItems()
        {
            var query = from _item in _context.Item
                        join _itempattern in _context.Itempattern
                        on _item.ItemPatternId equals _itempattern.ItemPatternId
                        select _item;
            List<Item> item = query.ToList();
            return item;
        }


        /// <summary>
        /// Implementacja procedury bazy danych sprawdzająca czy dany produkt się przeterminował
        /// W przypadku gdy się przeterminował jest ustawiana odpowiednia flaga w bazie
        /// </summary>
        /// 
        /// <remarks>Więcej na temat procedury w dokumantacji bazy</remarks>
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

        /// <summary>
        /// Implementacja procedury bazy danych sprawdzająca czy dany produkt się przeterminuje w najbliższym czasie
        /// W przypadku gdy się przeterminuje jest ustawiana odpowiednia flaga w bazie
        /// </summary>
        /// 
        /// <remarks>Więcej na temat procedury w dokumantacji bazy</remarks>
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


        /// <summary>
        /// Ścieżka do edycji danego produktu
        /// </summary>
        /// <param name="id">Identyfikator produktu w bazie</param>
        /// 
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

        /// <summary>
        /// Ścieżka do edycji danego produktu
        /// </summary>
        /// <param name="id">Identyfikator produktu w bazie</param>
        /// <exception cref="DbUpdateConcurrencyException"> Zwraca kiedy nie może zapisać do bazy </exception>
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




    }
}