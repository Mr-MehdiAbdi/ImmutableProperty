namespace ImmutableProperty
{
    internal class Person

    {
        /////////////////// 01 
        //   public string Name { get; private set; } = "Mehdi"; // Immutable property with private setter 

        // with method in immutable class to create a new instance with updated property value 

        //public void SetName(string name)
        //{
        //    Name = name;
        //}

        /////////////////// 02
        /// with const 
        /// value cannot be changed after compilation, so it is immutable by definition.
        /// value is set at compile time and cannot be modified at runtime.
        /// value is shared across all instances of the class, and it cannot be changed for any instance.

        //  public const string Name= "Ali"; // Immutable property with const value


        /////////////////// 03
        /// with readonly
        /// value can be assigned only during declaration or in the constructor.
        /// value cannot be changed after the object is constructed, making it immutable for that instance. 
        /// value is unique to each instance of the class.

        //public readonly string Name ="Mehdi"; // Initialization with  create


        /////////////////// 04
        /// inital with constructor
        //public readonly string Name;
        //public Person(string name)
        //{
        //    Name = name;
        //}



    }
}
