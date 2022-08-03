using ConfigsLoaderMockUp;

Console.WriteLine("Hello, World!");
var reader = new ReadGlobalConfig();
Console.WriteLine("Load All configs from folder (Yes/No)?");
string answer = Console.ReadLine().Trim().ToLower();
var result = answer == "yes";

reader.Read(result);

Type type = typeof(DataConfig);
foreach (var p in type.GetProperties())
{
    var value = p.GetValue(null, null);
    var output = value == null || string.IsNullOrEmpty(value.ToString()) ? "Value not found" : value.ToString();
    Console.WriteLine("Field " +p.Name + " value: " + output);
}

/*Please do also provide some thoughts(in textual form only) on how the following requirement could be implemented:
-it should provide information if variability constraints are violated 
	- Example: The parameter 'powerSupply' is required to be set to 'big' if the number of aisles in the sub-system config is >=5.*/

/*
 
 I would create new class which validates model/models and rearrange values by "existing rules" after loading single or all config files,
 since values given in config files can be in random order. 

 */