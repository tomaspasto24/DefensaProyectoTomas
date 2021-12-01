using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;
        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                bool precondition = value < 0;
                if (precondition)
                {
                    this.amount = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
        }
    }
}