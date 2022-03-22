using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2proj2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2proj2.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AppointmentController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = _userRepository.GetScheduledUsers();
            return View(users);
        }

        [HttpGet]
        [Route("/Appointment/Update/{id:int}")]
        public IActionResult Update(int id)
        {
            User u = _userRepository.GetUserById(id);
            return View(u);
        }

        [HttpPost]
        public IActionResult Update([FromForm] User u)
        {
            if (u.ErrorList().Count == 0)
            {
                User userToModify = _userRepository.GetUserById(u.GroupId);
                userToModify.IsAvailable = false;
                userToModify.Name = u.Name;
                userToModify.Email = u.Email;
                userToModify.Phone = u.Phone;
                userToModify.GroupSize = u.GroupSize;
                userToModify = _userRepository.UpdateUser(userToModify);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorList = u.ErrorList();
            }
            return View(u);
        }

        [Route("/Appointment/Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            User u = _userRepository.GetUserById(id);
            u.MakeAvailable();
            u = _userRepository.UpdateUser(u);
            return RedirectToAction("Index");
        }
    }
}
