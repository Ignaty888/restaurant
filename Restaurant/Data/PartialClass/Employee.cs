namespace Restaurant.Data
{
   public partial class Employee
    {
        public string PostName { get { return Post.PostName; } }

        public string EmployeeFio { get
            {
                return "(ID=" + ID_Employee + ") " + FName + " " + " " + EmpName + " " + LName;
            } }
    }
}
