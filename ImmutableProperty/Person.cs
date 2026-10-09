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


        /////////////////// 05
        /// inital with constructor and init property
        
        //Initialization with  create - 01 => initialization with  create - 01 => init property can be set only during object initialization, making it immutable after the object is created.
        //public string Name { get; init; }="Mehdi"; //

        public string Name { get; init; } // Initialization with

        // constructor => init property can be set only during object initialization, making it immutable after the object is created.
        //public Person(string name)
        //{
        //    Name = name;
        //}
        //  public string Name { get; init; } // Initialization with  create


        //////////////////////////////////////////////////////////////
        /// Summary of these topics and best practices with examples
        /// 
        /// 1. Use `const` for values that are compile-time constants and shared across all instances.
        /// 2. Use `readonly` for values that are assigned at runtime but should not change after construction.
        /// 3. Use `init` properties for values that should be set during object initialization and remain immutable afterwards.
        /// 4. Prefer `init` properties for most scenarios where immutability is desired, as they provide flexibility and clarity.
        /// The Best Practice
        /// Use `init` properties for creating immutable objects, as they allow setting values during object initialization while preventing modifications afterwards.

    }
}
