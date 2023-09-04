using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PassEstim
{
    public class PassEstimator
    {
        public int estimPass(string password) 
        {
            Regex digitsRegex = new Regex("\\d");
            Regex lowerCaseRegex = new Regex("[a-z]");
            Regex upperCaseRegex = new Regex("[A-Z]");
            Regex specialCharactersRegex = new Regex("[^a-zA-Z0-9]");
            int passMark = 0;
            
            if(digitsRegex.IsMatch(password))
            {
                passMark += 1;
            }
            if(lowerCaseRegex.IsMatch(password))
            {
                passMark += 1;
            }
            if(upperCaseRegex.IsMatch(password)) 
            { 
                passMark += 1;
            }
            if(specialCharactersRegex.IsMatch(password)) 
            { 
                passMark += 1; 
            }
            if(password.Length > 7) 
            {
                passMark += 1;
            }

            return passMark;
        }
    }
}
