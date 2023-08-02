﻿using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class PurchaseItems : Identifications
    {
        public PurchaseItems()
        {
            Products Product = new Products();
        }

        public int PurchaseId { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
        public double NewBaseUnCost { get; set; }
        public double TotalBaseCost { get; set; }
        public double PurchasePercentage { get; set; }
        public double NewUnCost { get; set; }
        public double WeightedCostAverage { get; set; }


    }
}
