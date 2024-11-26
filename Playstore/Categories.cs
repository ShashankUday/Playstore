using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class Categories
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // constructor : CLass Name and Method or function name should be same
        // it will trigger automatically when object is created 
        public Categories()
        {

        }

        public Categories(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;

        }

        public void AddCategory(int id, string name)
        {
            Console.WriteLine("Category Details " + id + "," + name);
        }
        public void AddCategory(int id, string name, string description)
        {
            Console.WriteLine("Category Details " + id + "," + name + "," + description);
        }
    }
}
