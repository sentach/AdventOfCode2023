// See https://aka.ms/new-console-template for more information

using Day01;

var fileReader = new FileReader("input.txt");
int suma = 0;
foreach(var dato in fileReader.ProcessFile(x => BuscarUltimoPrimero(x)))
{ 
    if(int.TryParse(dato, out int valor))
    {
        suma += valor;
    }
}
Console.WriteLine($"El valor es {suma}");

fileReader.Reset();

suma = 0;
foreach(var dato in fileReader.ProcessFile(x => BuscarNumerosEscritos(x)))
{
    if(int.TryParse(dato,out int valor))
    {
        suma += valor;
    }
}

Console.WriteLine($"El valor 2 es {suma}");

static string BuscarUltimoPrimero(string dato)
{
    char primero = ' ', ultimo=' ';
    foreach(var c in dato)
    {
        if (char.IsDigit(c))
        {
            if(primero == ' ') {  primero = c; }
            ultimo= c;
        }
    }
    return $"{primero}{ultimo}";
}

string BuscarNumerosEscritos(string dato)
{
    string primero="", segundo="";
    var delante = dato;
    while(delante.Length > 0)
    {
        if(delante.StartsWith("one") || delante.StartsWith("1"))
        {
            primero = "1";
            break;
        }
        if (delante.StartsWith("two") || delante.StartsWith("2"))
        {
            primero = "2";
            break;
        }
        if (delante.StartsWith("three") || delante.StartsWith("3"))
        {
            primero = "3";
            break;
        }
        if (delante.StartsWith("four") || delante.StartsWith("4"))
        {
            primero = "4";
            break;
        }
        if (delante.StartsWith("five") || delante.StartsWith("5"))
        {
            primero = "5";
            break;
        }
        if (delante.StartsWith("six") || delante.StartsWith("6"))
        {
            primero = "6";
            break;
        }
        if (delante.StartsWith("seven") || delante.StartsWith("7"))
        {
            primero = "7";
            break;
        }
        if (delante.StartsWith("eight") || delante.StartsWith("8"))
        {
            primero = "8";
            break;
        }
        if (delante.StartsWith("nine") || delante.StartsWith("9"))
        {
            primero = "9";
            break;
        }
        delante = delante[1..];
    }
    delante = dato;
    while (delante.Length > 0)
    {
        if (delante.EndsWith("one") || delante.EndsWith("1"))
        {
            segundo = "1";
            break;
        }
        if (delante.EndsWith("two") || delante.EndsWith("2"))
        {
            segundo = "2";
            break;
        }
        if (delante.EndsWith("three") || delante.EndsWith("3"))
        {
            segundo = "3";
            break;
        }
        if (delante.EndsWith("four") || delante.EndsWith("4"))
        {
            segundo = "4";
            break;
        }
        if (delante.EndsWith("five") || delante.EndsWith("5"))
        {
            segundo = "5";
            break;
        }
        if (delante.EndsWith("six") || delante.EndsWith("6"))
        {
            segundo = "6";
            break;
        }
        if (delante.EndsWith("seven") || delante.EndsWith("7"))
        {
            segundo = "7";
            break;
        }
        if (delante.EndsWith("eight") || delante.EndsWith("8"))
        {
            segundo = "8";
            break;
        }
        if (delante.EndsWith("nine") || delante.EndsWith("9"))
        {
            segundo = "9";
            break;
        }
        delante = delante[..^1];
    }
    return primero + segundo;
}
