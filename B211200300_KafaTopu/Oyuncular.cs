namespace KafaTopu;

public class Oyuncular
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Uzunluk { get; set; }
    private int sahaBoyu;

    public Oyuncular(int x, int sahaBoyu)
    {
        this.sahaBoyu = sahaBoyu;
        this.X = x;
        this.Y = sahaBoyu / 2;
        Uzunluk = sahaBoyu / 3;
    }

    public void Yukari()
    {
        if ((Y - 1 - (Uzunluk / 2)) != 0)
        {
            Console.SetCursorPosition(X, (Y + (Uzunluk / 2)) - 1);
            Console.Write("\0");
            Y--;
            Ciz();
        }
    }

    public void Asagi()
    {
        if ((Y + 1 + (Uzunluk / 2)) != sahaBoyu)
        {
            Console.SetCursorPosition(X, (Y - (Uzunluk / 2)));
            Console.Write("\0");
            Y++;
            Ciz();
        }
    }

    public void Ciz()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = (Y - (Uzunluk/2)); i < (Y+(Uzunluk/2)); i++)
        {
            Console.SetCursorPosition(X, i);
            Console.Write("|");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }

}