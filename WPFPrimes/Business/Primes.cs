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
        private List<String> listOfPrimeNumbers;

        public Primes()
        {
            listOfPrimeNumbers = new List<string>();
            GeneratePrimeNumberList();
        }

        private Boolean GeneratePrimeNumberList()
        {
            PrimeNumber primeNumber; 

            for (int iCont = 1; iCont <= 100000; iCont++){
                primeNumber = iCont;

                if (primeNumber.IsAPrimeNumber){
                    listOfPrimeNumbers.Add(primeNumber.Value.ToString());
                }
            }


            return listOfPrimeNumbers.Any()? true: false;
        }

        public List<String> GetListPrimeNumbers()
        {
            return listOfPrimeNumbers;
        }
    }
}
