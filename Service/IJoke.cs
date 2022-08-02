using DocumentFormat.OpenXml.Bibliography;
using FirstRestSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Person = FirstRestSharp.Models.Person;

namespace FirstRestSharp.Service
{
    public interface IJoke
    {
        Task<ServiceResponse<List<Person>>> Get();
 
    }
}
