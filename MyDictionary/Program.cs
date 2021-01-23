using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sakinDaireNo = new Dictionary<string, int>();
            sakinDaireNo.Add("Ali Yılmaz", 1);

            foreach (var apartmanSakini in sakinDaireNo)
            {
                Console.WriteLine(apartmanSakini);
            }

            Console.WriteLine();

            MyDictionary1<string, int> sakinDaireNo2 = new MyDictionary1<string, int>();
            sakinDaireNo2.Add("Ali Yılmaz", 1);
            sakinDaireNo2.Add("Elif Taşçı", 2);
            sakinDaireNo2.Add("Halil Yılmaz", 3);

            Console.WriteLine(sakinDaireNo2.Count);
            Console.WriteLine();
            foreach (var sakin in sakinDaireNo2.Keys)
            {
                Console.WriteLine(sakin);
            }

            foreach (var daireNo in sakinDaireNo2.Values)
            {
                Console.WriteLine(daireNo);
            }


        }
    }

    class MyDictionary1<TK, TV>
    {
        TK[] keys;
        TV[] values;


        public MyDictionary1()
        {
            keys = new TK[0];
            values = new TV[0];
        }


        public void Add(TK sakin, TV daireNo)
        {
            TK[] tempKeys = keys;
            TV[] tempValues = values;

            keys = new TK[keys.Length + 1];
            values = new TV[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }


            keys[keys.Length - 1] = sakin;
            values[values.Length - 1] = daireNo;

        }

        public TK[] Keys
        {
            get { return keys; }
        }

        public TV[] Values
        {
            get { return values; }
        }


        public int Count
        {
            get { return keys.Length; }
        }

    
    }
}
