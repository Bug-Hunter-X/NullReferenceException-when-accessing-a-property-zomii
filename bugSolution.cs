public class ExampleClass
{
    public int? MyProperty { get; set; } // Made nullable

    public void MyMethod()
    {
        // Safe access using null-conditional operator
        int? length = MyProperty?.ToString()?.Length; 

        //Check for null and handle appropriately
if (MyProperty.HasValue)
        {
            int value = MyProperty.Value.ToString().Length; 
        }
        else
        {
            // Handle the case where MyProperty is null
            Console.WriteLine("MyProperty is null");
        }
    }
}