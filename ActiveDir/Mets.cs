using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.IO.Compression;


namespace ActiveDir
{
    class Mets
    {
        public static string email_pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public static string serverFQDN_pattern = @"(?=^.{1,254}$)(^(?:(?!\d+\.)[a-zA-Z0-9_\-]{1,63}\.?)+(?:[a-zA-Z]{1,})$)";
        public static string organisationalUnit_pattern = @"^(?:(?:OU)\=\w+,){1,9}$";
        public static string Initial(string init)
        {
            init = init[0].ToString();
            if (init == "А" || init == "а") { init = init.Replace("А", "a"); init = init.Replace("а", "a"); }
            if (init == "Б" || init == "б") { init = init.Replace("Б", "b"); init = init.Replace("б", "b"); }
            if (init == "В" || init == "в") { init = init.Replace("В", "v"); init = init.Replace("в", "v"); }
            if (init == "Г" || init == "г") { init = init.Replace("Г", "g"); init = init.Replace("г", "g"); }
            if (init == "Д" || init == "д") { init = init.Replace("Д", "d"); init = init.Replace("д", "d"); }
            if (init == "Е" || init == "е") { init = init.Replace("Е", "e"); init = init.Replace("е", "e"); }
            if (init == "Ё" || init == "ё") { init = init.Replace("Ё", "e"); init = init.Replace("ё", "e"); }
            if (init == "Ж" || init == "ж") { init = init.Replace("Ж", "j"); init = init.Replace("ж", "j"); }
            if (init == "З" || init == "з") { init = init.Replace("З", "z"); init = init.Replace("з", "z"); }
            if (init == "И" || init == "и") { init = init.Replace("И", "i"); init = init.Replace("и", "i"); }
            if (init == "Й" || init == "й") { init = init.Replace("Й", "i"); init = init.Replace("й", "i"); }
            if (init == "К" || init == "к") { init = init.Replace("К", "k"); init = init.Replace("к", "k"); }
            if (init == "Л" || init == "л") { init = init.Replace("Л", "l"); init = init.Replace("л", "l"); }
            if (init == "М" || init == "м") { init = init.Replace("М", "m"); init = init.Replace("м", "m"); }
            if (init == "Н" || init == "н") { init = init.Replace("Н", "n"); init = init.Replace("н", "n"); }
            if (init == "О" || init == "о") { init = init.Replace("О", "o"); init = init.Replace("о", "o"); }
            if (init == "П" || init == "п") { init = init.Replace("П", "p"); init = init.Replace("п", "p"); }
            if (init == "Р" || init == "р") { init = init.Replace("Р", "r"); init = init.Replace("р", "r"); }
            if (init == "С" || init == "с") { init = init.Replace("С", "s"); init = init.Replace("с", "s"); }
            if (init == "Т" || init == "т") { init = init.Replace("Т", "t"); init = init.Replace("т", "t"); }
            if (init == "У" || init == "у") { init = init.Replace("У", "u"); init = init.Replace("у", "u"); }
            if (init == "Ф" || init == "ф") { init = init.Replace("Ф", "f"); init = init.Replace("ф", "f"); }
            if (init == "Х" || init == "х") { init = init.Replace("Х", "h"); init = init.Replace("х", "h"); }
            if (init == "Ц" || init == "ц") { init = init.Replace("Ц", "c"); init = init.Replace("ц", "c"); }
            if (init == "Ч" || init == "ч") { init = init.Replace("Ч", "c"); init = init.Replace("ч", "c"); }
            if (init == "Ш" || init == "ш") { init = init.Replace("Ш", "h"); init = init.Replace("ш", "h"); }
            if (init == "Щ" || init == "щ") { init = init.Replace("Щ", "h"); init = init.Replace("щ", "h"); }
            if (init == "Ы" || init == "ы") { init = init.Replace("Ы", "y"); init = init.Replace("ы", "y"); }
            if (init == "Э" || init == "э") { init = init.Replace("Э", "e"); init = init.Replace("э", "e"); }
            if (init == "Ю" || init == "ю") { init = init.Replace("Ю", "u"); init = init.Replace("ю", "u"); }
            if (init == "Я" || init == "я") { init = init.Replace("Я", "y"); init = init.Replace("я", "y"); }
            if (init == "Ъ" || init == "ъ") { init = init.Replace("Ъ", ""); init = init.Replace("ъ", ""); }
            if (init == "Ь" || init == "ь") { init = init.Replace("Ь", ""); init = init.Replace("ь", ""); }
            return init;
        }
        public static string Family(string famly)
        {
            famly = famly.Replace("А", "a");
            famly = famly.Replace("Б", "b");
            famly = famly.Replace("В", "v");
            famly = famly.Replace("Г", "g");
            famly = famly.Replace("Д", "d");
            famly = famly.Replace("Е", "e");
            famly = famly.Replace("Ё", "e");
            famly = famly.Replace("Ж", "zh");
            famly = famly.Replace("З", "z");
            famly = famly.Replace("И", "i");
            famly = famly.Replace("Й", "i");
            famly = famly.Replace("К", "k");
            famly = famly.Replace("Л", "l");
            famly = famly.Replace("М", "m");
            famly = famly.Replace("Н", "n");
            famly = famly.Replace("О", "o");
            famly = famly.Replace("П", "p");
            famly = famly.Replace("Р", "r");
            famly = famly.Replace("С", "s");
            famly = famly.Replace("Т", "t");
            famly = famly.Replace("У", "u");
            famly = famly.Replace("Ф", "f");
            famly = famly.Replace("Х", "kh");
            famly = famly.Replace("Ц", "ts");
            famly = famly.Replace("Ч", "ch");
            famly = famly.Replace("Ш", "sh");
            famly = famly.Replace("Щ", "shch");
            famly = famly.Replace("Ы", "y");
            famly = famly.Replace("Э", "e");
            famly = famly.Replace("Ю", "iu");
            famly = famly.Replace("Я", "ia");
            famly = famly.Replace("Ь", "");
            famly = famly.Replace("Ъ", "");
            famly = famly.Replace("а", "a");
            famly = famly.Replace("б", "b");
            famly = famly.Replace("в", "v");
            famly = famly.Replace("г", "g");
            famly = famly.Replace("д", "d");
            famly = famly.Replace("е", "e");
            famly = famly.Replace("ё", "e");
            famly = famly.Replace("ж", "zh");
            famly = famly.Replace("з", "z");
            famly = famly.Replace("и", "i");
            famly = famly.Replace("й", "i");
            famly = famly.Replace("к", "k");
            famly = famly.Replace("л", "l");
            famly = famly.Replace("м", "m");
            famly = famly.Replace("н", "n");
            famly = famly.Replace("о", "o");
            famly = famly.Replace("п", "p");
            famly = famly.Replace("р", "r");
            famly = famly.Replace("с", "s");
            famly = famly.Replace("т", "t");
            famly = famly.Replace("у", "u");
            famly = famly.Replace("ф", "f");
            famly = famly.Replace("х", "kh");
            famly = famly.Replace("ц", "ts");
            famly = famly.Replace("ч", "ch");
            famly = famly.Replace("ш", "sh");
            famly = famly.Replace("щ", "shch");
            famly = famly.Replace("ы", "y");
            famly = famly.Replace("э", "e");
            famly = famly.Replace("ю", "iu");
            famly = famly.Replace("я", "ia");
            famly = famly.Replace("ь", "");
            famly = famly.Replace("ъ", "");
            return famly;
        }
        public static string DNStoName(string _dnsname)
        {
            string[] _name = _dnsname.Split('.');
            return _name[0];
        }
        public static string DNStoDistinguishedName(string _dnsname)
        {
            string[] _name = _dnsname.Split('.');
            Array.Reverse(_name);
            string _DN = "";
            foreach (string _str in _name)
            {
                _DN = "DC=" + _str + "," + _DN;
            }
            _DN = _DN.Remove(_DN.Length - 1);
            return _DN;
        }
        public static void MaillWithoutAuth(string to, string from, string server, string theme, string body)
        {
            MailMessage message = new MailMessage(from, to);
            message.Subject = theme;
            message.Body = body;
            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = true;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}",
                            ex.ToString());
            }
        }
        long LongRandom(long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }
        public static string CreatePassword(int _length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < _length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public static string CreatePasswordStrongPolicy(int _length)
        {
            Dictionary<string, string> _characters = new Dictionary<string, string>();
            _characters.Add("_lovercase", "abcdefghijklmnopqrstuvwxyz");
            _characters.Add("_uppercase", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            _characters.Add("_number", "1234567890");
            _characters.Add("_special", "~!@#$%^&*_-+=`|(){}[]:;'<>,.?/");
            string _complexity = "";
            StringBuilder res = new StringBuilder();
            Random rndSymbol = new Random();
            Random rndCategory = new Random();
            while (0 < _length--)
            {
                var randomEntry = _characters.ElementAt(rndCategory.Next(0, _characters.Count));
                string randomKey = randomEntry.Key;
                string randomValue = randomEntry.Value;
                //MessageBox.Show("randomKey randomValue: " + randomKey + " = " + randomValue);
                if (0 < _length | !_complexity.Contains("l") | !_complexity.Contains("u") | !_complexity.Contains("n") | !_complexity.Contains("s"))
                {
                    string _variable = _characters[randomKey];
                    //MessageBox.Show("_variable: " + _variable);
                    res.Append(_variable[rndSymbol.Next(_characters[randomKey].Length)]);
                    _complexity += randomKey[1];
                    //MessageBox.Show("res.ToString(): " + res.ToString());
                }
                //MessageBox.Show("_complexity: " + _complexity);
            }
            //MessageBox.Show("RETURN res.ToString(): " + res.ToString());
            return res.ToString();
        }
        public static void CopyFile(string sourcefn, string destinfn)
        {
            FileInfo fn = new FileInfo(sourcefn);
            fn.CopyTo(destinfn, true);
        }
        public static void UnzippFile(string zipPath, string extractPath)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
        public static void ZippFile(string startPath, string zipPath)
        {
            ZipFile.CreateFromDirectory(startPath, zipPath);
        }
    }
}
