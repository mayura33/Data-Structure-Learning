using Datastructure.Basic_DS;
using Datastructure.LinkedList;
using Datastructure.Search;
using Datastructure.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("1", "2222");
            keyValues.Add("2", "4444");
            BST.Execute();
            Console.ReadLine();
        }
    }
}
