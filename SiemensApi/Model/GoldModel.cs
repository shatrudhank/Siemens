using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;
namespace SiemensApi.Model
{
    public class GoldModel
    {
        private double goldRate;
        private double goldWeight;
        private double goldDiscount;

        public double GoldRate
        {
            get { return goldRate; }
            set { this.goldRate = value; }
        }
        public double GoldWeight
        {
            get { return goldWeight; }
            set { this.goldWeight = value; }
        }
        public double GoldDiscount
        {
            get { return goldDiscount; }
            set { this.goldDiscount = value; }
        }
    }
}
