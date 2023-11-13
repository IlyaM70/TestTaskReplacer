using Microsoft.Extensions.Configuration;
using ReplacerClassLibrary.ReplacerStrategy;
using ReplacerClassLibrary;


// Get appsettings
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration config = builder.Build();

string? firstTaskString = config["FirstTask"];
string? secondTaskString = config["SecondTask"];
string? thirdTaskString = config["ThirdTask"];

if (string.IsNullOrEmpty(firstTaskString))
{
    throw new Exception("FirstTask not set in the appsetting.json file");
}
if (string.IsNullOrEmpty(secondTaskString))
{
    throw new Exception("SecondTask not set in the appsetting.json file");
}
if (string.IsNullOrEmpty(thirdTaskString))
{
    throw new Exception("ThirdTask not set in the appsetting.json file");
}

//Create replacer
Replacer replacer = new Replacer(new FirstTaskReplaceStrategy());

// Task 1
string firstTaskResult = MakeResult(replacer, firstTaskString);
PrintResult("First task", firstTaskString, firstTaskResult);

// Task 2
replacer.SetStrategy(new SecondTaskReplaceStrategy());
string secondTaskResult = MakeResult(replacer, secondTaskString);
PrintResult("Second task", secondTaskString, secondTaskResult);


// Task 3
replacer.SetStrategy(new ThirdTaskReplaceStrategy());
string thirdTaskResult = MakeResult(replacer, thirdTaskString);
PrintResult("Third task", thirdTaskString, thirdTaskResult);


string MakeResult(Replacer replacerStrategy, string taskString)
{
    int[] taskNumbers = Converter.NumbersStringToArray(taskString);
    return replacerStrategy.ReplaceNumbersByString(taskNumbers);
}

void PrintResult(string taskName, string taskString, string taskResult)
{
    Console.WriteLine($"{taskName} string:");
    Console.WriteLine(taskString);
    Console.WriteLine("Result:");
    Console.WriteLine(taskResult);
    Console.WriteLine();
}