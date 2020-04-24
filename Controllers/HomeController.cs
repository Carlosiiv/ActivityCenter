using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context { get; set; } //<-----Add This for DB

        public HomeController(MyContext context){ //<-----Add This for DB
            _context = context; //<-----Add This for DB
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("Register")]
        public IActionResult Register(User newUser){
            if( HttpContext.Session.Get("userId") != null){
                return RedirectToAction("Home");
            }
            else{
                if(ModelState.IsValid){
                    if(_context.Users.Any(u => u.Email == newUser.Email)){
                        ModelState.AddModelError("Email", "Email already in use!");
                        return View("Index");
                    }
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("userId",newUser.UserId);
                    return Redirect($"/Home");
                    }
                else{
                    return View("Index");
                }
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser newUser){
            if( HttpContext.Session.Get("userId") != null){
                return RedirectToAction("Home");
            }
            else{
                if(ModelState.IsValid){
                    User _user = _context.Users.FirstOrDefault(u => u.Email == newUser.LoginEmail);
                    if(_user ==null){
                        ModelState.AddModelError("LoginEmail","Invalid Email/Password");
                        ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                        return View("Login");
                    }
                    else{
                        PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                        var result = Hasher.VerifyHashedPassword(newUser, _user.Password, newUser.LoginPassword);
                        if(result == 0){
                            ModelState.AddModelError("LoginEmail","Invalid Email/Password");
                            ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                            return View("Login");
                        }
                        else{
                            HttpContext.Session.SetInt32("userId", _user.UserId);
                            return Redirect($"/home/");
                        }  
                    }  
                }
                else{
                    return View("Login");
                }
            }
        }
        
        [HttpGet("Logout")]
        public IActionResult Logout(){
           if( HttpContext.Session.GetInt32("userId") == null){
                return RedirectToAction("Index");
            }
            else{
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            } 
        }

        [HttpGet("Home")]
        public IActionResult Home(){
            if( HttpContext.Session.GetInt32("userId") == null){
                return RedirectToAction("Index");
            }
            else{

            User current = _context.Users
                                   .Include( o => o.Activities)
                                   
                                   .ThenInclude(o => o.NavigationalActivity)
                                   .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            ViewBag.CurrentTime = DateTime.Now;
            ViewBag.AllActivities = _context.Activities
                                             .Include( u => u.Users)
                                             .ThenInclude(nu => nu.NavigationalUser)
                                             .Include(a => a.Creator)
                                             .OrderBy(d => d.Date)
                                             .ThenBy(t => t.Time)
                                             .ToList();
            
            return View("Home",current);
            }
        }

        [HttpGet("/Activity/New")]
        public IActionResult NewActivity(){
            if( HttpContext.Session.GetInt32("userId") == null){
                return RedirectToAction("Index");
            }
            else{
                
            ViewBag.Creator = _context.Users
                                   .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            return View();
            }
        }
        [HttpPost("/Activity/New")]
        public IActionResult CreateActivity(Activ newActivity){
            if( HttpContext.Session.Get("userId") == null){
                return RedirectToAction("Home");
            }
            else{
                if(ModelState.IsValid){
                    var Creator = _context.Users
                                   .Include( a => a.Activities)
                                   .ThenInclude(na => na.NavigationalActivity)
                                   .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
                    
                    newActivity.UserId = Creator.UserId;
                    _context.Activities.Add(newActivity);
                    _context.SaveChanges();
                    return Redirect($"/Activity/{newActivity.ActivityId}");
                }
                else{
                    return View("NewActivity");
                }
            }
        }

        [HttpGet("Activity/{ActivId}")]
        public IActionResult OneActivity(int ActivId){

            ViewBag.Current = _context.Users
                                   .Include( o => o.Activities)
                                   .ThenInclude(o => o.NavigationalActivity)
                                   .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            var oneAct = _context.Activities
                                 .Include(o => o.Users)
                                 .ThenInclude(nu => nu.NavigationalUser)
                                 .Include(a => a.Creator)
                                 .FirstOrDefault(o => o.ActivityId == ActivId);
            
            return View("OneActivity",oneAct);
        }

        // [HttpGet("Activity/Complete/{ActivId}")]
        // public IActionResult ActivityComplete(int ActivId){

        //     ViewBag.Current = _context.Users
        //                            .Include( o => o.Activities)
        //                            .ThenInclude(o => o.NavigationalActivity)
        //                            .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
        //     var oneAct = _context.Activities
        //                          .Include(o => o.Users)
        //                          .ThenInclude(nu => nu.NavigationalUser)
        //                          .Include(a => a.Creator)
        //                          .FirstOrDefault(o => o.ActivityId == ActivId);
            
        //     return View("ActivityComplete",oneAct);
        // }

        [HttpGet("/Cancel/{ActivId}")]
        public IActionResult CancelActivity(int ActivId){
            var oneAct = _context.Activities
                                 .Include(o => o.Users)
                                 .ThenInclude(nu => nu.NavigationalUser)
                                 .FirstOrDefault(o => o.ActivityId == ActivId);
            var oneUser = _context.Users
                                  .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            if(oneAct.Creator.UserId != oneUser.UserId){
                return RedirectToAction("Home");
            }
            else{
                _context.Activities.Remove(oneAct);
                _context.SaveChanges();
                return RedirectToAction("Home");
            }
        }

        [HttpGet("/Join/{ActivId}")]
        public IActionResult Join(int ActivId,int UserId){
            var oneOcc = _context.Activities
                                 .Include(o => o.Users)
                                 .ThenInclude(nu => nu.NavigationalUser)
                                 .Include(c => c.Creator)
                                 .FirstOrDefault(o => o.ActivityId == ActivId);
            var oneUser = _context.Users
                                  .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            var RSVP = new Association();
            RSVP.ActivityId = oneOcc.ActivityId;
            RSVP.UserId = oneUser.UserId;
            _context.Associations.Add(RSVP);
            _context.SaveChanges();
            return Redirect("/Home");
        }

        [HttpGet("/Leave/{ActivId}")]
        public IActionResult CancelRSVP(int ActivId){
            var oneOcc = _context.Activities
                                 .FirstOrDefault(o => o.ActivityId == ActivId);
            var oneUser = _context.Users
                                  .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            var oneOUA = _context.Associations
                    .Where(ou => ou.NavigationalActivity.ActivityId == oneOcc.ActivityId)
                    .FirstOrDefault(ou =>ou.UserId == oneUser.UserId);
            _context.Associations.Remove(oneOUA);
            _context.SaveChanges();
            return Redirect("/Home");
        }



        
    }
}
