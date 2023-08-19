using ProjetoEduardoAnacletoWindowsForm1.Models;
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

        public int BillModelId { get; set; }
        public int BillNumberId { get; set; }
        public int BillSeriesId { get; set; }
        public int SupplierId { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
        public decimal NewBaseUnCost { get; set; }
        public decimal DiscountCash { get; set; }
        public decimal PreUnCost { get; set; }
        public decimal PurchasePercentage { get; set; }
        public decimal WeightedCostAverage { get; set; }
        public DateTime? CancelledDate { get; set; }


    }
}
