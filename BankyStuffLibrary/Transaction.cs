﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace BankyStuffLibrary
{
    public class Transaction
    {
        // properties
        public decimal Amount { get; }
        public string AmountForHumans { 
            get
            {
                return ((int)Amount).ToWords();
            }
                
        }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }
    }
}
