using Microsoft.AspNetCore.Mvc;
using RecipeWeb.Models;
using System.Collections.Generic;

namespace RecipeWeb.Controllers
{
  [Route("api/[controller]")]
  public class RecipeController : Controller
  {
    [HttpGet]
    public IEnumerable<Recipe> Get()
    {
      return new Recipe[0];
    }

    [HttpGet("{id}")]
    public Recipe Get(int id)
    {
      return new Recipe { Id = id };
    }

    [HttpPost]
    public int Post([FromBody]Recipe recipe)
    {
      return 1;
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Recipe recipe)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
