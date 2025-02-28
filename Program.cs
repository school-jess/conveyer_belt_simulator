// See https://aka.ms/new-console-template for more information
bool isPowerOn = true;
bool isEmergencyLightOn = false;
double getWeight()
{
    double weight = 0;
    try
    {
        weight = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("pls give a correct weight");
        throw new Exception();
    }
    return weight;
}
Console.WriteLine("conveyer belt is on");
while (isPowerOn && !isEmergencyLightOn)
{
    Console.WriteLine("Package Types");
    Console.WriteLine("* plastic");
    Console.WriteLine("* metal");
    Console.WriteLine("* glass");
    Console.Write("type of package? ");
    string package = Console.ReadLine();
    double weight = 0.0;
    switch (package)
    {
        case "plastic":
            Console.Write("Weight of the package: ");
            try
            {
                weight = getWeight();
            }
            catch
            {
                Console.WriteLine("emergency light on");
                isEmergencyLightOn = true;
            }
            if (weight < 0.1)
            {
                Console.WriteLine("emergency light on");
                isEmergencyLightOn = true;
            }
            else if (weight < 2.0)
            {
                Console.WriteLine("going to section a");
            }
            else if (weight == 4.0)
            {
                Console.WriteLine("going to section c");
            }
            else if (weight > 5.0)
            {
                Console.WriteLine("going to section d");
            }
            break;
        case "metal":
            Console.Write("Weight of the package: ");
            try
            {
                weight = getWeight();
            }
            catch
            {
                Console.WriteLine("emergency light on");
                isEmergencyLightOn = true;
            }
            if (weight < 0.1)
            {
                Console.WriteLine("emergency light on");
                isEmergencyLightOn = true;
            }
            else if (weight < 2.0)
            {
                Console.WriteLine("going to section a");
            }
            else if (weight > 1.9 && weight < 5.0)
            {
                Console.WriteLine("going to section b");
            }
            else if (weight > 5.0)
            {
                Console.WriteLine("going to section d");
            }
            break;
        case "glass":
            Console.Write("Weight of the package: ");
            try
            {
                weight = getWeight();
            }
            catch
            {
                Console.WriteLine("emergency light on");
                isEmergencyLightOn = true;
            }
            if (weight < 0.1)
            {
                Console.WriteLine("emergency light on");
                isEmergencyLightOn = true;
            }
            else if (weight > 1.9 && weight < 5.0)
            {
                Console.WriteLine("going to section b");
            }
            else if (weight > 5.0)
            {
                Console.WriteLine("going to section d");
            }
            break;
        default:
            Console.WriteLine("emergency light on");
            isEmergencyLightOn = true;
            break;
    }
}
Console.WriteLine("conveyer belt is off");
