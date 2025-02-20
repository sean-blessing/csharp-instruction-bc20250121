using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebAPIProject.Controllers {
    [Route("api/hello-world")]
    [ApiController]
    public class SimpleController : ControllerBase {
        private static List<string> names = new List<string>();

        // p. 51 - Manually add a controller
        [HttpGet("a")]
        public string HelloWorld() {
            return "Hello World!!!";
        }

        [HttpGet("b")]
        public string HelloWorld2() {
            return "abc";
        }

        // see bottom p. 43
        [HttpGet("say-hello/{message}")]
        public string SayHello(string message) {
            return $"Hello {message}";
        }

        [HttpGet("add-name/{name}")]
        public string AddName(string name) {
            names.Add(name);
            return $"{name} added";
        }
        [HttpGet("names")]
        public string GetNames() {
            string namesStr = string.Join("|", names);
            return namesStr;
        }
    }
}
