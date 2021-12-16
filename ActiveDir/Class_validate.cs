using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ActiveDir
{
    class Validate
    {
        public string __string_to_check;
        public string __regex_pattern;
        public bool ValidateStringByPattern()
        {
            if (!string.IsNullOrWhiteSpace(__string_to_check))
            {
                Regex reg = new Regex(__regex_pattern);
                if (!reg.IsMatch(__string_to_check))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }

}
