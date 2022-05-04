namespace KafaTopu;

class Top
{
    public int X { get; set; }
    public int Y { get; set; }
    private int yonX;
    private int yonY;
    private int sahaUzunlugu;
    private int sahaGenisligi;
    private int i;
    public int yon { get; set; }


    public Top(int x, int y, int sahaUzunlugu, int sahaGenisligi)
    {
        X = x;
        Y = y;
        this.sahaUzunlugu = sahaUzunlugu;
        this.sahaGenisligi = sahaGenisligi;
        yonX = -1;
        yonY = 1;
    }

    public void Logic(Oyuncular oyuncu1, Oyuncular oyuncu2)
    {
        Console.SetCursorPosition(X,Y);
        Console.Write("\0");
        if (Y <= 1 || Y >=sahaUzunlugu-2)
        {
            yonY *= -1;
        }

        if ((X == 3 || X == sahaGenisligi -3) && (oyuncu1.Y - (oyuncu1.Uzunluk / 2)) <= Y && (oyuncu1.Y + (oyuncu1.Uzunluk/2)) > Y
            && (oyuncu2.Y - (oyuncu2.Uzunluk / 2)) <= Y && (oyuncu2.Y + (oyuncu2.Uzunluk / 2)) > Y)
        {
            yonX *= -1;

            if (Y == oyuncu1.Y || Y == oyuncu2.Y)
            {
                yon = 0;
            }

            if ((Y >= (oyuncu1.Y - (oyuncu1.Uzunluk/2)) && Y < oyuncu1.Y) || (Y > oyuncu1.Y && Y < (oyuncu1.Y + (oyuncu1.Uzunluk/2)))
                || (Y >= (oyuncu2.Y - (oyuncu2.Uzunluk / 2)) && Y < oyuncu2.Y) || (Y > oyuncu2.Y && Y < (oyuncu2.Y + (oyuncu2.Uzunluk / 2))))
            {
                yon = 1;
            }
        }

        switch (yon)
        {
            case 0:
                X += yonX;
                break;
            case 1:
                X += yonX;
                Y += yonY;
                break;
        }
    }

    public void Ciz()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(X,Y);
        Console.Write("O");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0,0);

    }

}