using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa4.Models
{
    public class FileValidation
    {
        public (bool Success, string[] Lines, int LineQuantity) ReadFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                return (true, lines, lines.Length);
            }
            catch (Exception)
            {
				return (false, new string[0], 0);
			}
		}
    }
}