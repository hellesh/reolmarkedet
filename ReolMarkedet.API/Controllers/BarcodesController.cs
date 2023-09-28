using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReolMarkedet.Domain.Repository;

namespace ReolMarkedet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BarcodesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult GetById()
        {
            var barcodesFromRepo = _unitOfWork.Barcode.GetAll();
            return Ok(barcodesFromRepo);
        }
    }
}
