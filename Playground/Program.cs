// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(GetGlCodeFromLedger("123456789099999999996767"));


 string GetGlCodeFromLedger(string ledger)
{
    var cleanLedger = ledger.Trim();


    if (cleanLedger.Length = 0)
    {
        return string.Empty;
    }

    if (cleanLedger.Length > 12)
    {
        return cleanLedger.Substring(6, 6);
    }

    return string.Empty;
}
