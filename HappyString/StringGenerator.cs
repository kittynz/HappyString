using System;
using System.Linq;

namespace HappyString
{
    public class StringGenerator
    {
        private string[] _happyList = new string[] {"smile", "kitten", "ice cream", "holiday"};

        public string Get()
        {
            if (!_happyList.Any())
                return string.Empty;

            var r = new Random(100);
            var happyIndex = r.Next(0, _happyList.Length - 1);
            return _happyList[happyIndex];
        }
    }
}
