using System;
using System.IO;
using System.Collections.Generic;

namespace Task_4
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadText(string filePath)
        {
            var lines = new List<char[]>();
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line.ToCharArray());
                }
            }
            return lines.ToArray();
        }
    }
}

