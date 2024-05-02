using Elliman.Service.DataValidation.CLASSES;


public class Validator
{
    static void Main()
    {
        Console.WriteLine("Test");
        OfficeValidator o = new();
        o.validateManagers();
    }
}
