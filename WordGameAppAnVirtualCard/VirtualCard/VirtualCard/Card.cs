﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualCard
{
    public abstract class Card
    {
        private long _id;
        public long Id { get { return _id; } }

        private long _amount =0; 
        public long Amount { get { return _amount; } }

        private DateTime date;
        public DateTime LastUsingTime { get { return date; } }

        public Card(long id, long amount, DateTime lastUsingTime)
        {
            CardUpdate(id, amount, lastUsingTime);
        }

        public abstract void ShowData();

        protected void CardUpdate(long id, long amount,DateTime lastUsingTime)
        {

            _id = id;
            _amount = amount;
            date = lastUsingTime;
        }

        public void TakeMoney(long amount)
        {
            if (amount > this.Amount)
                throw new Exception("You don't have that much money");
            _amount -= amount;
        }

        public void AddMoney(long amount)
        {
            this._amount += amount;
        }
    }

    public class UserCard:Card
    {

        private List<VirtualCard> virtualCards = new List<VirtualCard>();
        

        public void CreateVirualCard(long amount)
        {
            if (amount > this.Amount)
            {
                Console.WriteLine("You don't have that much money");
                return;
            }
            if (VirtualCard.MinAmount > amount)
            {
                Console.WriteLine("Minum Amount :" + VirtualCard.MinAmount + ". You don't have that much money");
                return;
            }

            if (this.virtualCards.Count <5)
            {
                Random random = new Random();
            NotUsibleId:;
                long cardId = long.Parse(random.Next(10000000, 99999999).ToString() 
                    + random.Next(10000000, 99999999).ToString());
                

                if (!IsUsingId(cardId))
                    goto NotUsibleId;

                this.TakeMoney(amount);
                VirtualCard virtualCard = new VirtualCard(cardId, amount, CaculateLastUsingTime(amount));
                virtualCards.Add(virtualCard);
                virtualCard.ShowData();
                Console.WriteLine("\n Virtual CardCreated");
            }
            else
                Console.WriteLine("You Have 5 Virual Card. This Is Limit");
        }

        private bool IsUsingId(long cardId)
        {
            bool isUsibleId = true;
            foreach (var item in virtualCards)
            {
                if (item.Id == cardId)
                {
                    isUsibleId = false;
                    break;
                }
            }
            return isUsibleId;
        }


        public DateTime CaculateLastUsingTime(long amount)
        {
            if (amount < VirtualCard.MinAmount)
                throw new Exception("Min Amount :" + VirtualCard.MinAmount);

            DateTime lastUsingTime = DateTime.Now;
            if (amount > 200 && amount <= 300)
                lastUsingTime  = DateTime.Now.AddDays(5);
            else if (amount > 300 &&  amount<= 500)
                lastUsingTime = DateTime.Now.AddDays(15);
            else
                lastUsingTime = DateTime.Now.AddDays(31);
            return lastUsingTime;
        }

        

        public void RemoveVirtualCard(long Id)
        {
            if (IsUsingId(Id))
            {
                var card = virtualCards.Find(dr => dr.Id == Id);
                this.AddMoney(card.Amount);
                card.ShowData();
                virtualCards.Remove(card);
                Console.WriteLine("\n Virtual CardCreated");

            }
            else
                Console.WriteLine("This Card Not Found");
        }

        public override void ShowData()
        {
            Console.WriteLine($"\nCard Number: {this.Id} ");
            Console.WriteLine($"Card Amount: {this.Amount} " + $"/ Card Last Using Date : {this.LastUsingTime.ToShortDateString()}");
            Console.WriteLine("================= Virtual Card =====================");

            int count = 1;
            foreach (var item in virtualCards)
            {
                
                Console.WriteLine($"--------------- Virtual Card {count} -------------------");
                Console.WriteLine($" >>>>>>>>>> Card Number: {item.Id} ");
                Console.WriteLine($" >>>>>>>>>> Card Amount: {item.Amount} " + $"/ Card Last Using Date : {item.LastUsingTime.ToShortDateString()}");
                ++count;
            }
        }

        public UserCard(long id, long amount, DateTime lastUsingTime) : base(id, amount, lastUsingTime) { }

    }

    
    public class VirtualCard :Card
    {

       
        private static long _minAmount =200;
        public static long MinAmount { get { return _minAmount; } }
        public VirtualCard(long id, long amount, DateTime lastUsingTime) : base(id, amount, lastUsingTime) { }

        public override void ShowData()
        {
            Console.WriteLine($"\nCard Number: {this.Id} ");
            Console.WriteLine($"Card Amount: {this.Amount} " + $"/ Card Last Using Date : {this.LastUsingTime.ToShortDateString()}");

        }
    }


   

}
