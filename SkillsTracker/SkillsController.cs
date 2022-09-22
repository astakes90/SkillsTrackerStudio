using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker
{
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = @"<h1>Skills Tracker</h1>
                <h2>Coding Skills to Learn:</h2>
                <ol>
                <li>C#</li>
                <li>JavaScript</li>
                <li>Python</li>
                </ol>
                ";

            return Content(html, "text/html");
        }

        [HttpGet("/skills/form")]
        public IActionResult FormGet()
        {
            string html = @"
            <form method='post' action='/skills/form'>
            <h1>Date</h1>
            <input type='date' name = 'date'>
            <br/>
            <label for='cSharp'>C#: </label>
            <select name = cSharp>
            <option value='learning basics'>Learning basics</option>
            <option value='making apps'>Making apps</option>
            <option value='master coder'>Master coder</option>
            </select>
            <br/>
            <label for='javascript'>JavaScript: </label>
            <select name = javascript>
            <option value='learning basics'>Learning basics</option>
            <option value='making apps'>Making apps</option>
            <option value='master coder'>Master coder</option>
            </select>
            <br/>
            <label for='python'>Python: </label>
            <select name = python>
            <option value='Learning basics'>Learning basics</option>
            <option value='Making apps'>Making apps</option>
            <option value='Master coder'>Master coder</option>
            </select>
            <br/>
            <button type='submit'>Submit</button>
            </form>
            ";

            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult FormPost(string date, string cSharp, string javascript, string python)
        {
            string html = $"<h1>{date}</h1>" + "<br/>" + $"C#: {cSharp}" + "<br/>" + $"JavaScript: {javascript}" + "<br/>" + $"Python: {python}";

            return Content(html, "text/html");
        }
    }
}

