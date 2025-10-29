using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LevakovaAA.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int currentCount = 0;
            char previosChar = '\0';
            foreach (char chr in value)
            { 
                if (chr == 'y')
                {
                    if (previosChar == 'y')
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > count)
                    {
                        count = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
                previosChar = chr;
            }
            return count;
        }
    }
}
