using Microsoft.AspNetCore.Mvc;
using System;

namespace CommandsService.Controllers;

[ApiController]
[Route("api/c/[controller]")]
public class PlatformsController : ControllerBase
{
    public PlatformsController()
    {

    }
    [HttpPost]
    public ActionResult TestInBoundConnection()
    {
        Console.WriteLine("---> Inbound Post # Command Service");

        return Ok("Inbound platform service at Commands Service Project");
    }
}
