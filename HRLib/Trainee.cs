using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
        private int noOfDays;

        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }
        private double ratePerDAY;

        public double RatePerDAY
        {
            get { return ratePerDAY; }
            set { ratePerDAY = value; }
        }

        public Trainee():base()
        {
            NoOfDays = 5;
            RatePerDAY = 5;
        }

        public Trainee(string name,string address,int _noofdays,double _rateperday):base(name , address)
        {
            this.NoOfDays=_noofdays;
            this.RatePerDAY=_rateperday;
        }

        public override double CalculateSalary()
        {
            return NoOfDays * RatePerDAY;
        }
        public override string ToString()
        {
            return base.ToString() + $" NoOfDays: {NoOfDays}, RatePerDAY: {RatePerDAY}";
        }
    }
}
