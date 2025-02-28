// See https://aka.ms/new-console-template for more information
bool isPowerOn = true;
bool isEmergencyLightOn = false;
Console.WriteLine("conveyer belt is on");
while (isPowerOn && !isEmergencyLightOn)
{
    Console.WriteLine("Package Types");
    Console.WriteLine("* plastic");
    Console.WriteLine("* metal");
    Console.WriteLine("* glass");
    Console.Write("type of package? ");
    string package = Console.ReadLine();
    Console.Write("Weight of the package: ");
    double weight = 0;
    try
    {
        weight = Convert.ToDouble(Console.ReadLine());
    }
    catch {
    	Console.WriteLine("pls give a correct weight");
    	continue;
    }
    if ((package == "metal" || package == "plastic") && (weight < 2.0 && weight > 0.0))
    {
        Console.WriteLine("Package going to section A");
    }
    else if ((package == "metal" || package == "glass") && (weight > 1.9 || weight < 5.0))
    {
        Console.WriteLine("Package going to section B");
    }
    else if (package == "plastic" && weight == 4.0)
    {
        Console.WriteLine("Package going to section C");
    }
    else if (weight > 5.0)
    {
        Console.WriteLine("Package going to section D");
    }
    else
    {
    	Console.WriteLine("emergency light on");
        isEmergencyLightOn = true;
    }
}
Console.WriteLine("conveyer belt is off");
