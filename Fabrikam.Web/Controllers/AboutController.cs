using Microsoft.AspNetCore.Mvc;

namespace Fabrikam.Web.Controllers
{
    public class AboutController : Controller
    {
        private readonly IRequestRepository _requestRepository;

        public AboutController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public IActionResult Index()
        {
            var requests = _requestRepository.Get("setId2");
            return View();
        }

    }
}
