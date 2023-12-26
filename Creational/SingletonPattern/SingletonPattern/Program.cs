// See https://aka.ms/new-console-template for more information

using SingletonPattern;

string foo = ConfigurationManager.Instance.GetSetting("harun");
Console.WriteLine(foo);

string foo2 = ConfigurationManager.Instance.GetSetting("mehmet");
Console.WriteLine(foo2);

string foo3 = ConfigurationManager.Instance.GetSetting("harun");
Console.WriteLine(foo3);

string foo4 = ConfigurationManager.Instance.GetSetting("harun");
Console.WriteLine(foo4);

