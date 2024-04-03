namespace ConsoleApp
{
    public class GenericClass<T> where T: struct
    {
        public T Value { get; set; }
    }
}
