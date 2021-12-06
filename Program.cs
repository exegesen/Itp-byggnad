class Program {

    //Skrivet av Jonathan Jönsson för Arbetsmarknadsutbildning .Net Lexicon AB
    public static void Main(String[] args) {
        
        //1. Funktion som skriver ut ”Hello World” i konsolen
        Console.WriteLine("Uppgift 1");
        Console.WriteLine("Hello World!"); // 1
        Console.WriteLine();

        //2. Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut
        //dessa i konsolen
        Console.WriteLine("Uppgift 2");
        Console.WriteLine("Skriv Förnamn");//2
        String arg0 = Console.ReadLine();
        Console.WriteLine("Skriv Efternamn");
        String arg1 = Console.ReadLine();
        Console.WriteLine("Skriv Ålder");
        String arg2 = Console.ReadLine();
        Console.WriteLine(arg0 + " " + arg1 + " " + arg2); //2
        Console.WriteLine();

        //3. Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder
        //funktionen igen
        Console.WriteLine("Uppgift 3");
        changeTextColor();
        Console.WriteLine("KOLLA HÄR");
        Thread.Sleep(1000);
        changeTextColor();
        Console.WriteLine("KOLLA DÄR");
        Console.WriteLine();

        //4
        Console.WriteLine("Uppgift 4");
        printDate();
        Console.WriteLine();

        //5
        Console.WriteLine("Uppgift 5");
        compareNum(1, 2);
        compareNum(1, 1);
        compareNum(2,1);
        Console.WriteLine();

        //6
        Console.WriteLine("Uppgift 6");
        guessNumber();
        Console.WriteLine();

        //7
        Console.WriteLine("Uppgift 7");
        saveLine();
        Console.WriteLine();

        //8
        Console.WriteLine("Uppgift 8");
        readFile();
        Console.WriteLine();

        //9
        Console.WriteLine("Uppgift 9");
        decimaltal();
        Console.WriteLine();


        //10
        Console.WriteLine("Uppgift 10");
        multiplikationstabell();
        Console.WriteLine();

        //11
        Console.WriteLine("Uppgift 11");
        twoArrays();
        Console.WriteLine();

        //12
        Console.WriteLine("Uppgift 12");
        palindrome();
        Console.WriteLine();
        Console.WriteLine();

        //13
        Console.WriteLine("Uppgift 13");
        twoInputs();
        Console.WriteLine();

        //14
        Console.WriteLine("Uppgift 14");
        commaSeparated();
        Console.WriteLine();

        //15
        Console.WriteLine("Uppgift 15");
        commaAdded();
        Console.WriteLine();
        
        //16
        Console.WriteLine("Uppgift 16");
        character();
        Console.WriteLine();
    }

    //3
    static void changeTextColor() {
        if ((Console.BackgroundColor != ConsoleColor.Black) && Console.ForegroundColor != ConsoleColor.White)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
        }
    }

    static void printDate() {
        Console.WriteLine(DateTime.Now);
    }

    static void compareNum(int n1, int n2) {
        if (n1 >= n2) {
            Console.WriteLine(n1);
        }
        else {
            Console.WriteLine(n2);
        }
        return;
    }

    static void guessNumber() {
        int randNum = (new Random()).Next(0,101);
        Console.WriteLine("Random number generated. Guess the number in range 1-100");
        int guess = 0;
        int tries = 0;
        while (true)
        {
                String arg0 = Console.ReadLine();

            guess = int.Parse(arg0);
            if (randNum == guess)
            {
                Console.WriteLine("Correct! Amount of guesses: " + tries);
                return;
            }
            else if (guess > randNum)
            {
                tries++;
                Console.WriteLine("Too high!");
            }
            else if (guess < randNum) {
                tries++;
                Console.WriteLine("Too low!");
            }
            
        }
    }

    static async void saveLine() {
     Console.WriteLine("Skriv in en textrad");
        String txt = ""; 
        txt = Console.ReadLine();
        await File.WriteAllTextAsync("TEXTRAD.txt", txt);
        Console.WriteLine("Textrad läst och sparad till TEXTRAD.txt");
    }

    static async void readFile() {
        Console.WriteLine("Läser filen TEXTRAD.txt");
        String s;
        s = File.ReadAllText("TEXTRAD.txt");
        Console.WriteLine(s);
    }
    static void decimaltal() {
        
        Console.WriteLine("Skriv ett decimaltal t.ex 6,99 ");
        String s = Console.ReadLine();
        Double d = Double.Parse(s);
        Console.WriteLine("sqrt("+d+")"+"^2");
        Console.WriteLine(Math.Pow(Math.Sqrt(d), 2));
        Console.WriteLine("sqrt(" + d + ")" + "^10");
        Console.WriteLine(Math.Pow(Math.Sqrt(d), 10)); // tolkar uppgiften som att du vill ha en gång upphöjt till 2 och en annan upphöjt till 10
                                                       // men det går naturligtvis också att tolka som:
        Console.WriteLine("sqrt(" + d + ")" + "^2^10");
        Console.WriteLine( Math.Pow(Math.Pow(Math.Sqrt(d), 2),10));

    }
    static void multiplikationstabell() {
        int tabell = 1;
        int tal = 1;
        for (tabell = 1; tabell < 11; tabell++) {
            Console.WriteLine(tabell +"ans multiplikationstabell");
            for (tal = 1; tal < 11; tal++) {
                Console.Write(tal * tabell + "  ");
            }
            Console.WriteLine();
        }
    
    }

    static void twoArrays() {
        const int ARRSIZE = 5;
        int[] arr1 = new int[ARRSIZE];
        int[] arr2 = new int[ARRSIZE];
        Random randnum = new Random();

        /*fill arr1*/
        for (int i = 0; i < arr1.Length; i++) {
            arr1[i] = randnum.Next(100);
            arr2[i] = arr1[i];
        }

        /*Print array1*/
        Console.WriteLine("arr1");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i]+ " ");
        }
        Console.WriteLine();

        /*Sort arr1 and put in arr2*/

        int temp;
        for (int j = 0; j <= arr2.Length - 2; j++)
        {
            for (int i = 0; i <= arr2.Length - 2; i++)
            {
                if (arr2[i] > arr2[i + 1])
                {
                    temp = arr2[i + 1];
                    arr2[i + 1] = arr2[i];
                    arr2[i] = temp;
                }
            }
        }

        /*Print arr2 sorted arr1*/
        Console.WriteLine("arr2");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine();

    }

    static void palindrome() {
        int input = -1;
        int r = -1;
        int sum = 0;
        int temp = -1;
        Console.Write("Enter the Number: ");
        String s = Console.ReadLine();
        input = int.Parse(s);
        temp = input;
        while (input > 0)
        {
            r = input % 10;
            sum = (sum * 10) + r;
            input = input / 10;
        }
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");


    }

    static void twoInputs() {
        String s1;
        String s2;
        int i1;
        int i2;
        Console.WriteLine("Input number 1");
        s1 = Console.ReadLine(); 
        Console.WriteLine("Input number 2");
        s2 = Console.ReadLine();
        i1 = int.Parse(s1);
        i2 = int.Parse(s2);

        if (i1 > i2) { //flippa om dålig ordning
            int temp = 0;
            temp = i2;
            i2 = i1;
            i1 = temp;
        }

        int difference = i2 - i1;

        for (int i = i1 + 1; i <= difference; i++) {
            Console.Write(i + " ");
        }

    }

    static void commaSeparated()
    {
        /*14. Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan
    sorteras och skrivs ut efter udda och jämna värden.*/
        int[] num;
        LinkedList<int> evenlist = new LinkedList<int>();
        LinkedList<int> oddlist = new LinkedList<int>();
        Console.WriteLine("Input comma separated numbers 1, 2, 3, 4 for example");
        string input = Console.ReadLine();
        num = Array.ConvertAll(input.Split(','), int.Parse);
        foreach (int i in num)
        {
            if (i % 2 == 0)
            {
                evenlist.AddLast(i);
            }
            if (i % 2 == 1)
            {
                oddlist.AddLast(i);
            }
        }
        Console.Write("oddlist ");
        foreach (int i in oddlist)
        {
            Console.Write(i + " ");

        }
        Console.WriteLine();
        Console.Write("evenlist ");
        foreach (int i in evenlist)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void commaAdded()
    {
        Console.WriteLine("Write a comma-separated list of numbers like 1,2,3 ");
        string input = Console.ReadLine();
        int[] num;
        num = Array.ConvertAll(input.Split(','), int.Parse);
        int sum = 0;
        foreach (int i in num) {
            sum += i;
        }
        Console.WriteLine("Sum: " + sum);
    }
    class Data
    {
        String namn;
        int Hälsa;
        int Styrka;
        int Tur;
        public Data(String inputnamn)
        {   
            Random rand = new Random();
            namn = inputnamn;
            Hälsa = rand.Next(100);
            Styrka = rand.Next(100);
            Tur = rand.Next(100);
        }
        public void printData() {
            Console.WriteLine("Namn: " + this.namn);
            Console.WriteLine("Hälsa: " + this.Hälsa);
            Console.WriteLine("Styrka: " + this.Styrka);
            Console.WriteLine("Tur: " + this.Tur);
        }
    }
    static void character()
    {
        Console.WriteLine("Character name input");
        string name0 = Console.ReadLine();
        Console.WriteLine("Enemy input");
        string name1 = Console.ReadLine();
        Data data = new Data(name0);
        Data data2 = new Data(name1);
        Console.WriteLine();
        data.printData();
        Console.WriteLine();
        data2.printData();


    }

}
