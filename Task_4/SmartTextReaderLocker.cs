using System;
using System.Text.RegularExpressions;

namespace Task_4
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private readonly ISmartTextReader _realReader;
        private readonly Regex _blockedPattern;

        public SmartTextReaderLocker(ISmartTextReader realReader, string pattern)
        {
            _realReader = realReader;
            _blockedPattern = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public char[][] ReadText(string filePath)
        {
            if (_blockedPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }

            return _realReader.ReadText(filePath);
        }
    }
}

