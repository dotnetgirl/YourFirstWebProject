using App.Domain;
using App.Service;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _service;

    public UsersController(UserService service)
    {
        _service = service;
    }

        // GET: api/products/5
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var product = _service.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<User> AddProduct(User user)
        {
            _service.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }
    }
