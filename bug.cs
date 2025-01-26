public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a null reference
        int value = MyProperty.ToString().Length; // NullReferenceException if MyProperty is not initialized 
    }
}