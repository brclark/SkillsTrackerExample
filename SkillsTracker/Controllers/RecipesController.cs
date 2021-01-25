using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{
    public class RecipesController : Controller
    {
        // GET: /recipes/
        // Display recipeList.html content
        [HttpGet]
        [Route("/recipes")]
        public IActionResult Index()
        {
            string html = "<h2>Recipe List</h2>";

            html += "<ol>" +
                "<li>Eggs benedict</li>" +
                "<li>Grilled cheese and tomato soup</li>" +
                "<li>Lentil soup</li>" +
                "</ol>";

            return Content(html, "text/html");
        }


        // GET: /recipes/form
        // Display recipeForm.html content
        [HttpGet]
        [Route("/recipes/form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/recipes/form'>" +
                "<label>Recipe Name" +
                "<input type='text' name='name' />" +
                "</label>" +
                "<label>Vegetarian" +
                "<input type='checkbox' name='isVegetarian' value='true' />" +
                "</label>" +
                "<input type='submit' value='Add Recipe' />" +
                "</form>";

            return Content(html, "text/html");
        }


        // POST: /recipes/form
        // Incoming parameters
        // string name
        // bool isVegetarian
        [HttpPost]
        [Route("/recipes/form")]
        public IActionResult FormResult(string name, bool isVegetarian = false)
        {
            string html = "";

            if (isVegetarian)
            {
                html += "<h2>New Vegetarian Recipe Added</h2>";
            } else
            {
                html += "<h2>New Recipe Added</h2>";
            }

            html += "<ul>" +
                $"<li>{name}</li>" +
                "</ul>";


            return Content(html, "text/html");
        }
    }
}
