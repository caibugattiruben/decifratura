string cifrazione(string messaggio, int tipo, int chiave)
{
    messaggio = messaggio.ToLower();
    int[] posizioni = new int[messaggio.Length];
    string lettere = " abcdefghijklmnopqrstuvwxyz";
    int pos = 0;
    string lettera;
    string mes1 = messaggio;
    string[] mes2 = new string[mes1.Length];
    if (tipo == 1)
    {
        for (int i = 0; i < messaggio.Length; i++)
        {
            for (int j = 0; j < lettere.Length; j++)
            {
                if (messaggio[i] == lettere[j])
                {
                    posizioni[i] = j;
                }
            }
        }
        messaggio = "";
        for (int i = 0; i < mes1.Length; i++)
        {
            if (posizioni[i] + chiave > 26)
            {
                pos = (posizioni[i] + chiave) - 26;
                messaggio += lettere[pos].ToString();
            }
            else
            {
                messaggio += lettere[posizioni[i] + chiave].ToString();
            }

        }
    }
    else
    {
        if (chiave % mes1.Length == 0)
        {
            messaggio = mes1;
        }
        else
        {
            while (chiave > mes1.Length)
            {
                chiave -= mes1.Length;
            }
            for (int i = 0; i < messaggio.Length; i++)
            {
                posizioni[i] = i;
            }
            for (int i = 0; i < mes1.Length; i++)
            {
                if (posizioni[i] + chiave >= mes1.Length)
                {
                    pos = (posizioni[i] + chiave) - mes1.Length;
                    mes2[pos] = mes1[i].ToString();
                }
                else
                {
                    pos = posizioni[i] + chiave;
                    mes2[pos] = mes1[i].ToString();
                }



            }

        }
        messaggio = "";
        for (int i = 0; i < mes2.Length; i++)
        {
            messaggio += mes2[i];
        }
    }
    messaggio = messaggio.ToUpper();
    return messaggio;
}
string decifrazione(string messaggio, int tipo, int chiave)
{
    messaggio = messaggio.ToLower();
    int[] posizioni = new int[messaggio.Length];
    string lettere = "abcdefghijklmnopqrstuvwxyz";
    int pos = 0;
    string lettera;
    string mes1 = messaggio;
    string[] mes2 = new string[mes1.Length];
    if (tipo == 1)
    {
        for (int i = 0; i < messaggio.Length; i++)
        {
            for (int j = 0; j < lettere.Length; j++)
            {
                if (messaggio[i] == lettere[j])
                {
                    posizioni[i] = j;
                }
            }
        }
        messaggio = "";
        for (int i = 0; i < mes1.Length; i++)
        {
            if (posizioni[i] - chiave < 0)
            {
                pos = (posizioni[i] - chiave) + 26;
                messaggio += lettere[pos].ToString();
            }
            else
            {
                messaggio += lettere[posizioni[i] - chiave].ToString();
            }

        }
    }
    else
    {

        {
            if (chiave % mes1.Length == 0)
            {
                messaggio = mes1;
            }
            else
            {
                while (chiave > mes1.Length)
                {
                    chiave -= mes1.Length;
                }
                for (int i = 0; i < messaggio.Length; i++)
                {
                    posizioni[i] = i;
                }
                for (int i = 0; i < mes1.Length; i++)
                {
                    if (posizioni[i] - chiave < 0)
                    {
                        pos = (posizioni[i] - chiave) + mes1.Length;
                        mes2[pos] = mes1[i].ToString();
                    }
                    else
                    {
                        pos = posizioni[i] - chiave;
                        mes2[pos] = mes1[i].ToString();
                    }



                }

            }
            messaggio = "";
            for (int i = 0; i < mes2.Length; i++)
            {
                messaggio += mes2[i];
            }
        }
    }

    messaggio = messaggio.ToUpper();
    return messaggio;
}
Console.WriteLine("dammi il tuo messaggio");
string messaggio = Console.ReadLine();
Console.WriteLine("vuoi una cifrazione o decifrazione (1. cifrazione  2.decifrazione)");
int tipo1 = int.Parse(Console.ReadLine());
Console.WriteLine("dimmi il tipo di cifrazione o decifrazione (1. a sostituzione  2. a trasposizione)(se sbagli a scrivere farà una trasposizione)");
int tipo = int.Parse(Console.ReadLine());
Console.WriteLine("dimmi con quale chiave");
int chiave = int.Parse(Console.ReadLine());
if (tipo1 == 1)
{
    Console.WriteLine("il tuo messaggio ora è: " + cifrazione(messaggio, tipo, chiave));
}
else
{
    Console.WriteLine("il tuo messaggio ora è: " + decifrazione(messaggio, tipo, chiave));
}
