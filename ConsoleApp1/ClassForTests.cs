using System;
using System.IO;

namespace NUnitTestProject1
{
    public class ClassForTests
    {
        public string GetStringFromObject(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value is string)
            {
                return (string)value;
            }

            return null;
        }

        public void WriteTextToFile(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }
    }
}
