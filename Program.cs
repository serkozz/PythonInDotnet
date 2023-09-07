using Python.Runtime;

Console.WriteLine($"---------- C# ----------");
var pythonCode = await File.ReadAllTextAsync($@"C:\Repositories\Dotnet\PythonInDotnet\main.py");
Runtime.PythonDLL = "python311.dll";
PythonEngine.Initialize();
using (Py.GIL())
{
    try
    {
        PythonEngine.Exec(pythonCode);
    }
    catch (Exception ex)
    {
        if (ex.Message != "0")
            Console.WriteLine($"Exception: {ex.Message}");
    }
}
PythonEngine.Shutdown();
Console.WriteLine($"---------- End C# ----------");