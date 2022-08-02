using AutoMapper;
using FirstRestSharp.Data;
using FirstRestSharp.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRestSharp.Service
{
    public class Joke : IJoke
    {
        private readonly RestClient _client;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public Joke(IMapper mapper,DataContext context)
        {
            _client = new RestClient("https://daddyjokes.p.rapidapi.com/random");
            _mapper = mapper;
            _context = context;
        }




        public async Task<ServiceResponse<List<Person>>> Get()
        {
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "1c31112a0amsh23855d24984a28ap1bcb69jsna8c1f442f294");
            request.AddHeader("X-RapidAPI-Host", "daddyjokes.p.rapidapi.com");

            ServiceResponse<List<Person>> x = new ServiceResponse<List<Person>>();
            RestResponse response = await _client.ExecuteGetAsync(request);
            Person person = new Person();


            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            ///*****************

            foreach (var item in result)
            {
                person.Content = item.Value;
            }
            person.Id = Guid.NewGuid();
            person.IsSuccessful = true;

            x.Data = _context.Persons.Select(c=> _mapper.Map<Person>(c)).ToList();
            _context.AddRange(person);
            await _context.SaveChangesAsync();



            return x;

        }


    }
}
