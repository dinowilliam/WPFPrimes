using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPrimes.Contracts;

namespace WPFPrimes.Business
{
    public class Primes : IPrimes
    {
        public Primes()
        {
            
        }

        public List<String> GetListPrimeNumbers()
        {
            return new List<String>();
        }
    }
}
