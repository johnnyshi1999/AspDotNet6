using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNet6.Service
{
    public class DemoService : IDemoService
    {
        private static readonly string[] Locations = new[]
        {
            "Hanoi", "Washington", "Sydney"
        };
        public string GetLocationById(int i)
        {
            try
            {
                return Locations[i];
            } catch(Exception)
            {
                throw;
            }
            
        }
    }
}
