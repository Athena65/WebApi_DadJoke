using System;
using System.Text.Json;

namespace FirstRestSharp.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }


    }
}
