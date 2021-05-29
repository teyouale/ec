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
    public class PostsController : Controller
    {
        private List<Post> _post;
        static List<string> strings = new List<string>()
        {
            "1","2","3"
        };

       
        public PostsController()
        {
            _post = new List<Post>();
            for (int i = 0; i < 5; i++)
            {
                _post.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return strings;
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }
    }
}
