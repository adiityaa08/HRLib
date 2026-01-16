namespace HRLib
{
    public abstract class Employee
    {
        #region properties
        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string address;

		public string Address
        {
			get { return address; }
			set { address = value; }
		}
		private static int count = 100;
		private int empNO;
		public int EmpNO
		{
			get { return empNO; }
			private	set { empNO = value; }
		}
        #endregion

        #region constructor
        public Employee()
		{
			Name = "aditya";
			Address = "mumbai";
			EmpNO = count++;
		}
		public Employee(string _name, string _address):this()
		{
			this.name = _name;
			this.address = _address;
		}
        #endregion
        public abstract double CalculateSalary();

        public override string ToString()
        {
            return $" Name: {Name}, Address: {Address}, Empno:{EmpNO}";
        }

    }
}
