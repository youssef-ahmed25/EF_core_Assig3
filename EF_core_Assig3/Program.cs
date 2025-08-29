using EF_core_Assig3.Context;
using EF_core_Assig3.Entity;

namespace EF_core_Assig3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDB context = new ITIDB();
            //Department dept = new Department()
            //{
            //    Name = "IT",
            //    HiringDate = DateTime.Now,
            //    ins_ID = 1
            //};
            //context.Add(dept);
            //context.SaveChanges();

            //List<Department> dept = new List<Department>
            //    {
            //        new Department(){Name = "IT",HiringDate = new DateTime(2025, 3, 4), ins_ID = 2},
            //        new Department(){Name = "CS",HiringDate = new DateTime(2023, 5, 6),ins_ID = 1},
            //        new Department(){Name = "HR", HiringDate = new DateTime(2022, 7, 8), ins_ID = 3}

            //    };
            //context.AddRange(dept);
            //context.SaveChanges();
        }
    }
}
