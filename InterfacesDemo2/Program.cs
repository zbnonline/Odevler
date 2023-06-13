using System;

namespace InterfacesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface'ler new lenemez. 
            //IPersonManager personManager = new IPersonManager();

            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager)
        }
    }

    interface IPersonManager
    {
        //unimplemented opration
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Customer güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Employee güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
