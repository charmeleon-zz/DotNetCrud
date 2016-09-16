using System;

namespace CrudForm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new DatabaseContext())
            {
                db.Users.Add(new User {FirstName = "Max", LastName = "Power", Phone = "555-123-4567", Address = "12345 Pennsylvania Ave" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} users created", count);

                Console.WriteLine("Users in CRUD DB:");
                foreach (var user in db.Users)
                {
                    Console.WriteLine(" * {0}", user.FirstName + " " + user.LastName);
                }
            }
        }
    }
}
