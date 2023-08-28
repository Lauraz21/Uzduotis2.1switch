Console.WriteLine("Pasirinkite viena is 5 elementu: " +
    "\nUgnis  -1" +
    "\nVanduo -2 " +
    "\nOras   -3 " +
    "\nZeme   -4" + 
    "\nEteris -5 ");
int elements = Convert.ToInt32(Console.ReadLine());

switch (elements)
{
    case 1:
        Console.WriteLine("UGNIS - degimo proceso metu išsiskiriančios " +
            "\nįkaitusios, šviečiančios dujos. ");
        break;
    case 2:
        Console.WriteLine("VANDUO – bespalvis (storame sluoksnyje – žydras)" +
            "\nir bekvapis skystis.");
        break;

    case 3:
        Console.WriteLine("ORAS - dujų mišinys, sudarantis Žemės atmosferą.");
        break;
    case 4:
        Console.WriteLine("ZEME - Žemės rutulys, Pasaulis) – Saulės sistemos planeta.");
        break;
    case 5:
        Console.WriteLine("ETERIS - organiniai junginiai, kuriuose angliavandenilių " +
            "\nradikalus jungia deguonies atomas.");
        break;

    default:
        Console.WriteLine("Klaida");
        break;
}