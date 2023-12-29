Dog dog = new Dog();

Console.Write("Enter dog name: ");        
string name = Console.ReadLine();

dog.SetName(name);

Console.WriteLine("Dog name: " + dog.GetName());
dog.Eat();