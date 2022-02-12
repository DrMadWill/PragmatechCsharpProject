using System;

namespace VirtualCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();
            long cardId = long.Parse(random.Next(10000000, 99999999).ToString()
                + random.Next(10000000, 99999999).ToString());


            UserCard card = new UserCard(cardId, 5000, DateTime.Now.AddDays(75));

            card.CreateVirualCard(500);
            card.CreateVirualCard(500);
            card.CreateVirualCard(500);
            card.CreateVirualCard(500);
            card.CreateVirualCard(500);
            card.CreateVirualCard(500);
            long id = long.Parse(Console.ReadLine());
            card.RemoveVirtualCard(id);

            card.ShowData();




        }
    }
}
