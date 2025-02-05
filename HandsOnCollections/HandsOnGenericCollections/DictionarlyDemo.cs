﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class DictionarlyDemo
    {
        static void Main()
        {
            //Dictionary<int, string> obj = new Dictionary<int, string>()
            //{
            //    [12234]="Suren",
            //    [5678]="Jessi",
            //    [09089]="Peter"
            //};
            SortedDictionary<int, string> obj = new SortedDictionary<int, string>() //stores the data sroted order of the key
            {
                [12234] = "Suren",
                [5678] = "Jessi",
                [09089] = "Peter"
            };
            obj.Add(1234, "Rohan");
            string ename = obj[5678];
            foreach(var key in obj.Keys)
            {
                Console.WriteLine("{0} {1}", key, obj[key]);
            }
            foreach(KeyValuePair<int,string> item in obj)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }
    }
}
