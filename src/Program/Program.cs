namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public void Main()
    {
        DateFormatter format = new DateFormatter();
        string testDate = "10/11/1997";
        Console.WriteLine($"{testDate} se convierte a {format.ChangeFormat(testDate)}");
    }
}