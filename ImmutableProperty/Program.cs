//ImmutableProperty

using ImmutableProperty;

//Person p= new Person();
//p.Name = "Mehdi"; // error => This line will cause a compilation error because the setter is private
//p.SetName("farhad");
//Console.WriteLine($"Name: {p.Name}");


///////// 04
/// inital with constructor

//Person p=new("Mehdi");
//p.name = "Mehdi"; // error => This line will cause a compilation error because the Name property is readonly and can only be set in the constructor
//Console.WriteLine($"Name: {p.Name}");



////// 05
// constructor => init property can be set only during object initialization, making it immutable after the object is created.
//Person person = new Person("Mehdi"); ok

Person person = new Person() // ok
{
    Name = "Mehdi"
};
//person.Name("a"); // error => This line will cause a compilation error because the Name property is init-only
//Console.WriteLine($"Name: {person.Name}");

// initail object with init property =>ok