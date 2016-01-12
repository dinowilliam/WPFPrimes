using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPrimes.Contracts;

namespace WPFPrimes.Business
{
    public class PrimeNumber : IPrimeNumber
    {        
        public int Value;

        public PrimeNumber(int value)
        {
            Value = value;
        }

        public static implicit operator PrimeNumber(int value)
        {
            return new PrimeNumber(value);
	    }

        public Boolean IsAPrimeNumber
        {
            get{
                Boolean isPrime = false;
                Boolean isBreak = false;

                if (Value <= 1){
                    isPrime = false;
                }
                else if (Value <= 3){
                    isPrime = true;
                }                    
                else if (Value % 2 == 0 || Value % 3 == 0){
                    isPrime = false;
                }
                else {    
                    
                    int i = 5;

                    while(i*i <= Value){

                        if (Value % i == 0 || Value % (i + 2) == 0){
                            isPrime = true;
                            isBreak = true;
                            break;
                        }                        

                        i = i + 6;
                    }

                    if (!isBreak) { isPrime = true; }
                }
                
                return isPrime;
            }
        }

    }
}
