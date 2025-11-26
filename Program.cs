global using Diogris.InterfacesWorkshop.Abstractions;

using Diogris.InterfacesWorkshop.Services;

var logger = new Logger();
var calculator = new Calculator();

var worker = new Worker(logger, calculator);

worker.Run();

Console.ReadKey();
