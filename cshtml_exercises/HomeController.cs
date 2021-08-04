public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.userName = "이안주";
            ViewBag.userAge = 25;

            return View();
        }

        public ActionResult Test(string name, int ID = 1)
        {
            ViewBag.userName = name;
            ViewBag.userID = ID;
            return View();
        }

        public ActionResult Razorpage()
        {
            return View();
        }
    }
