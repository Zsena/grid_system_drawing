/* drawing columns

Console.Write("How many columns should I draw (10-50): ");

int colNum = int.Parse(Console.ReadLine());

while (colNum < 10 || colNum > 50)

{

  Console.ForegroundColor = ConsoleColor.Red;

  Console.WriteLine("\n\tNem megfelelő számot adott meg!");

  Console.ResetColor();

  Console.Write("\nHow many columns should I draw (10-50): ");

  colNum = int.Parse(Console.ReadLine());

}

Console.CursorVisible = false;

Console.Clear();

int maxX = Console.WindowWidth - 1;

int maxY = Console.WindowHeight - 1;

Random r = new Random();

ConsoleKeyInfo keyboard;

do

{

  int height = r.Next(1, maxY);

  int y = maxY;

  int x = r.Next(0, maxX - 1);

  Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);

  for (int i = 0; i < height; i++)

  {

    Console.SetCursorPosition(x, y - i);

    Console.Write("*");

    System.Threading.Thread.Sleep(10);

  }

  colNum--;

  keyboard = Console.ReadKey(true);

} while (colNum > 0 && keyboard.Key != ConsoleKey.Escape); */
/* drawing program

Console.CursorVisible = false;

int xMax = Console.WindowWidth;

int yMax = Console.WindowHeight;

int x = xMax / 2;

int y = yMax / 2;

string drawingMark = "*";

ConsoleKeyInfo keyboard;

do

{

    Console.SetCursorPosition(x, y);

    Console.Write(drawingMark);

    keyboard = Console.ReadKey(true);

    switch (keyboard.Key)

    {

        case ConsoleKey.RightArrow:

            if (x == xMax-1) Console.Beep(1000, 100); else x++;

            break;

        case ConsoleKey.LeftArrow:

            if (x == 0) Console.Beep(1000, 100); else x--;

            break;

        case ConsoleKey.UpArrow:

            if (y == 0) Console.Beep(1000, 100); else y--;

            break;

        case ConsoleKey.DownArrow:

            if (y == yMax - 1) Console.Beep(1000, 100); else y++;

            break;

        case ConsoleKey.P:

            Console.ForegroundColor = ConsoleColor.Red;

            break;

        case ConsoleKey.Z:

            Console.ForegroundColor = ConsoleColor.Green;

            break;

        case ConsoleKey.S:

            Console.ForegroundColor = ConsoleColor.Yellow;

            break;

        case ConsoleKey.F:

            Console.ForegroundColor = ConsoleColor.White;

            break;

        case ConsoleKey.Delete:

            if (drawingMark == "*")

            {

                drawingMark = "";

                Console.CursorVisible = true;

            }

            else

            {

                drawingMark = "*";

                Console.CursorVisible = false;

            }

            break;

    }

} while (keyboard.Key != ConsoleKey.Escape);*/
//draw a square in the center of the screen
// please enter the size of the square at the beginning (min 3 and max 10)
/* solid square

int xmax = Console.WindowWidth;

int ymax = Console.WindowHeight;

Console.Write("Kérem a négyzet élhosszát (3-10): ");

int meret = int.Parse(Console.ReadLine());

Console.CursorVisible = false;

while (meret < 3 || meret > 10)

{

    Console.WriteLine("Rossz érték!");

    Console.Write("Kérem a négyzet élhosszát (3-10): ");

    meret = int.Parse(Console.ReadLine());

}

Console.Clear();

for (int i = 0; i < meret; i++)

{

    Console.SetCursorPosition((xmax - meret) / 2 + i, (ymax - meret) / 2);

   

    for (int y = 0; y < meret; y++)

    {

        Console.SetCursorPosition((xmax - meret) / 2 + i, (ymax - meret) / 2 + y);

        Console.Write('*');

    }

}

Console.ReadKey();*/
// open square
Console.WriteLine("Square drawing program\n");

int xMax = Console.WindowWidth;

int yMax = Console.WindowHeight;

Console.WriteLine("Enter the dimensions of the square. (3-10)");

Console.Write("Width: ");

int width = int.Parse(Console.ReadLine());

Console.Write("Height: ");

int height = int.Parse(Console.ReadLine());


while (width > 10 || width < 3 || height > 10 || height < 3)

{

  Console.WriteLine("Improper dimensions enter the dimensions of the square. (3-10)");

  Console.Write("Width: ");

  width = int.Parse(Console.ReadLine());

  Console.Write("Height: ");

  height = int.Parse(Console.ReadLine());
}

int startX = (xMax - width) / 2;

int startY = (yMax - height) / 2;

for (int i = 0; i < width; i++)

{

  Console.SetCursorPosition(startX + i, startY);

  Console.Write("*");

  Console.SetCursorPosition(startX + i, startY + height);

  Console.Write("*");

}

for (int j = 0; j < height; j++)

{

  Console.SetCursorPosition(startX, startY + j);

  Console.Write("*");

  Console.SetCursorPosition(startX - 1 + width, startY + 1 + j);

  Console.Write("*");

}

Console.ReadKey();


