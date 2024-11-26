using Playstore;

Console.WriteLine("My Play Store");
 // how to create object for class ( instance for a class )
 User userO =  new User();
 userO.CreateUser();// function call , without function call there will be no output
Console.WriteLine(userO.Name);

Categories categories = new Categories(11,"Fachion","Fachion teshhjkl"); 
Console.WriteLine(categories.ID);
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);

categories.AddCategory(1, "asdf");
categories.AddCategory(2, "fdx", "jhgfds");
categories.AddCategory(3 , "asdfg" ,"asdfghjklkjhgfds");