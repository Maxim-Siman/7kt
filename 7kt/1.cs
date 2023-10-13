//interface IConverter<T, U>
//{
//    U Convert(T value);
//}
//public class StringToIntConverter : IConverter<string, int>
//{
//    public int Convert(string value)
//    {
//        if (int.TryParse(value, out int result))
//        {
//            return result;
//        }
//        else
//        {
//            return 0;
//        }
//    }
//}
//class ObjectToStringConverter : IConverter<object, string>
//{
//    public string Convert(object value)
//    {
//        if(value != null)
//        {
//            return value.ToString();
//        }
//        return string.Empty;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        StringToIntConverter stringToIntConverter = new StringToIntConverter();
//        ObjectToStringConverter objectToStringConverter = new ObjectToStringConverter();
//        int First = stringToIntConverter.Convert("123");
//        string Second = objectToStringConverter.Convert(1234);
//        Type type = First.GetType();
//        Type type2 = Second.GetType();
//        string typeName = type.Name;
//        string typeName2 = type2.Name;
//        Console.WriteLine($"{First}-{typeName}, {Second}-{typeName2}");
//    }
//}