using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message):base(true,message) //çift parametreli base const u çalıştır.
        {

        }
        public SuccessResult():base(true)//tek parametreliyi çalıştır
        {
            
        }
    }
}
