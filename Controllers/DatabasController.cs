using Microsoft.AspNetCore.Mvc;
using A_Visit_To_Georgia.Models;
using A_Visit_To_Georgia.Repositories;

namespace A_Visit_To_Georgia.Controllers
{
    public class DatabasController : Controller
    {
        private readonly IBokningRepository _bokningRepository;
        private readonly IMenuItemRepository _menuItemRepository;

        public DatabasController(
            IBokningRepository bokningRepository,
            IMenuItemRepository menuItemRepository)
        {
            _bokningRepository = bokningRepository;
            _menuItemRepository = menuItemRepository;
        }

        // ===== BOKNINGAR =====
        public IActionResult Index()
        {
            var bokningar = _bokningRepository.GetAll();
            return View(bokningar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Skapa(Bokningbord nyBokning)
        {
            if (!ModelState.IsValid)
                return View("~/Views/Home/Bokabord.cshtml", nyBokning);

            _bokningRepository.Add(nyBokning);
            _bokningRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bokning = _bokningRepository.GetById(id);
            if (bokning == null) return NotFound();
            return View(bokning);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Bokningbord bokning)
        {
            if (!ModelState.IsValid) return View(bokning);

            _bokningRepository.Update(bokning);
            _bokningRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bokning = _bokningRepository.GetById(id);
            if (bokning == null) return NotFound();
            return View(bokning);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var bokning = _bokningRepository.GetById(id);
            if (bokning == null) return NotFound();

            _bokningRepository.Delete(bokning);
            _bokningRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        // ===== MENY (ADMIN/CRUD) =====

        // Lista (admin)
        public IActionResult Menu()
        {
            var items = _menuItemRepository.GetAll();
            return View(items);
        }

        // Skapa
        [HttpGet]
        public IActionResult MenuCreate() => View(new MenuItem());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MenuCreate(MenuItem item)
        {
            if (!ModelState.IsValid) return View(item);

            _menuItemRepository.Add(item);
            _menuItemRepository.Save();
            return RedirectToAction(nameof(Menu));
        }

        // Redigera
        [HttpGet]
        public IActionResult MenuEdit(int id)
        {
            var item = _menuItemRepository.GetById(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MenuEdit(MenuItem item)
        {
            if (!ModelState.IsValid) return View(item);

            _menuItemRepository.Update(item);
            _menuItemRepository.Save();
            return RedirectToAction(nameof(Menu));
        }

        // Radera
        [HttpGet]
        public IActionResult MenuDelete(int id)
        {
            var item = _menuItemRepository.GetById(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("MenuDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult MenuDeleteConfirmed(int id)
        {
            var item = _menuItemRepository.GetById(id);
            if (item == null) return NotFound();

            _menuItemRepository.Delete(item);
            _menuItemRepository.Save();
            return RedirectToAction(nameof(Menu));
        }
    }
}
