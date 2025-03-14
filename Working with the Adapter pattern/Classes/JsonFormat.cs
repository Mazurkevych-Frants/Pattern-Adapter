using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Working_with_the_Adapter_pattern.Interfaces;

namespace Working_with_the_Adapter_pattern.Classes
{
    public class JsonFormat : IJson
    {
        public void GetJson()
        {
            Console.WriteLine("Получаем данные в формате json.");
        }
    }
}
