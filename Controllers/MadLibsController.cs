// Richard Johnson
// 10-26-22
// This program will take the user's input through the URL and print them in a Mad Libs story that the user can read

//Peer review: Reed Goodwin-A very well written story that fits the guidelines perfectly, runs well and functions as intended!

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRMadLibsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibsController : ControllerBase
{
    [HttpGet]
    [Route("Mad/{name}/{color}/{noun}/{animal}/{location}/{noun2}/{adjective}/{noun3}/{adjective2}/{verb}/{noun4}")]

    public string MadLibs(string name, string color, string noun, string animal, string location, string noun2, string adjective, string noun3, string adjective2, string verb, string noun4)
    {

        // This is where the variables will be printed
        return $"{name} lived in a {color} {noun}. One day, {name} met a talking {animal} who wanted to go for a walk through the {location}. They both walked together, and ended up becoming good friends with each other. After a while, they would find a magic {noun2} that they thought was very {adjective}. {name} used it to turn the {animal} into a {noun3} for no reason, and the {animal} felt {adjective2} about this. After turning the {animal} back to normal, {name} and the {animal} both {verb} to the top of a {noun4} to relax. \nTHE END";
    }

}
