using ec.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ec.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private List<Post> _post;
        public PostsController()
        {
            _post = new List<Post>();
            for(int i = 0; i < 5; i++)
            {
                _post.Add(new Post { Id = Guid.NewGuid().ToString() }); 
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rng = "hisada";
            return Ok(_post);
        }
    }
}
