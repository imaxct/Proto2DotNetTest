// See https://aka.ms/new-console-template for more information
using Microsoft.Exchange.Data;

Console.WriteLine("Hello, World!");
var d = new DirectoryIdentityData() {
 DatabaseGuid = Guid.NewGuid().ToString()
};
Console.WriteLine(d.ToString());