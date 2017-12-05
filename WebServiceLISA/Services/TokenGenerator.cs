using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceLISA.Services
{
    public class TokenGenerator
    {
        public static string Generate()
        {
            Random rand = new Random();
            string chain = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            string result = "";
            for(uint i = 0; i < 25; i++)
            {
                string add = chain[rand.Next(0, chain.Length - 1)].ToString();
                add = rand.Next(0, 100) > 50 ? add.ToLower() : add;
                result += add;
            }

            return result;
        }
    }
}
