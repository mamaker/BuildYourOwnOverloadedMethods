using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnOverloadedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            Console.WriteLine(doesItMatch);
            bool doesItMatch2 = Card.DoesCardMatch(cardToCheck, Values.Three);
            Console.WriteLine(doesItMatch2);
        }
    }
}
