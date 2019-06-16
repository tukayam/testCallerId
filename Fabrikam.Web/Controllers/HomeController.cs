using Microsoft.AspNetCore.Mvc;

namespace Fabrikam.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRequestRepository _requestRepository;

        public HomeController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public IActionResult Index()
        {
            var requests = _requestRepository.Get("setId1");
            return View();
        }

    }
}
