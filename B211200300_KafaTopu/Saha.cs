namespace B211200300_KafaTopu;

public class Saha
{
    public int Uzunluk { get; set; } 
    public int Genislik { get; set; }

    public Saha()
    {
        Uzunluk = 30;
        Genislik = 119;
    }

    public Saha(int uzunluk, int genislik)
    {
        Uzunluk = uzunluk;
        Genislik = genislik;
    }

    public void Ciz()
    {

        for (int i = 0; i < Genislik; i++)
        {
            Console.SetCursorPosition(i,0);
            Console.Write("-");
        }

        for (int i = 0; i < Genislik; i++)
        {
            Console.SetCursorPosition(i, Uzunluk-1);
            Console.Write("-");
        }

        for (int i = 0; i < Uzunluk; i++)
        {
            Console.SetCursorPosition(0,i);
            Console.Write("|");
        }

        for (int i = 0; i < Uzunluk; i++)
        {
            Console.SetCursorPosition(Genislik,i);
            Console.Write("|");
        }

        Console.SetCursorPosition(0, 0);
        Console.Write("┌");
        Console.SetCursorPosition(Genislik, 0);
        Console.Write("┐");
        Console.SetCursorPosition(0, Uzunluk-1);
        Console.Write("└");
        Console.SetCursorPosition(Genislik, Uzunluk-1);
        Console.Write("┘");

    }
}