
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee 
    {
		private double basic;

		public double Basic
		{
			get { return basic; }
            set
            {
                if (value < 5000)
                {
                    throw new BasicTooLowException("basic is less than minimum");
                }
                basic = value;
            }
		}
		private string designation;

		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}

		public ConfirmEmployee():base()
		{

            Basic = 100;
			Designation = "Not Assigned";

        }
        public ConfirmEmployee(string name, string address, double _basic, string _designation)
            : base(name, address) // ✅ Pass 2 args to base class constructor
        {
            this.Basic = _basic;
            this.Designation = _designation;
        }

        public sealed override double CalculateSalary()
        {

            double hra, conv, pf;

            if (Basic >= 30000)
            {
                hra = Basic * 0.30;
                conv = Basic * 0.30;
                pf = Basic * 0.10;
            }

            else if (Basic >= 20000)
            {
                hra = Basic * 0.20;
                conv = Basic * 0.20;
                pf = Basic * 0.10;
            }
            else
            {
                hra = Basic * 0.10;
                conv = Basic * 0.10;
                pf = Basic * 0.10;
            }

            return Basic + hra + conv - pf;
        }

        public override string ToString()
        {
            return base.ToString() + $" Designation: {Designation}, Basic: {Basic}";
        }

    }
}
