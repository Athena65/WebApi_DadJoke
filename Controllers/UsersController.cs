using AutoMapper;
using FirstRestSharp.Data;
using FirstRestSharp.Migrations;
using FirstRestSharp.Models;
using FirstRestSharp.Service;
using Google.Api.Ads.AdWords.v201809;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirstRestSharp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly IJoke _joke;

        public UsersController(IJoke joke)
        {
            _joke = joke;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await _joke.Get());



        }
      

       
    }
    
}
