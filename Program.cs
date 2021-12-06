class Game {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Arena Battle Game! Input character name");
        String startname = Console.ReadLine();
        Character player = new Character(startname,25,100,100);
        Gear.createNewGear("BlåSword",10,20);
        Gear.createNewGear("RedSword", 15, 25);
        Gear.createNewGear("GreenSword", 20, 30);
        Gear.createNewGear("BlackSword", 25, 45);
        Gear.createNewGear("Dagger", 5, 15);
        Gear.createNewGear("Koskenkorva", 5, 10);
        Gear.createNewGear("Kalashnikov", 500, 1000);
        Gear.createNewGear("Älgstudsare", 200, 300);
        player.weapon = Gear.emptyGear();

        while (true) { 
            Console.WriteLine("S for stats\nB for new battle\nT for store\nA for stat shop");
            String input = Console.ReadLine();
            if (input.Equals("S") || input.Equals("s"))
            {
                player.printStats();
            }
            else if (input.Equals("T") || input.Equals("t"))
            {
                Console.WriteLine("Available in the store:");
                Console.WriteLine(Gear.getListOfGear());
                Boolean bought = false;
                while (!bought) { 
                    Console.WriteLine("Write the weapon you want to buy!");
                    Console.WriteLine("Currency available: " + player.currency);
                    String s = Console.ReadLine();
                    Gear g = Gear.getGear(s);
                    if ((g.cost > player.currency))
                    {
                        Console.WriteLine("Sorry! Not enough currency!");
                    }
                    else
                    {
                        Console.WriteLine("Returned " + g.name + "Correct? Yes (Y) No (N)");
                        String inputt = Console.ReadLine();
                        if (inputt.Equals("Y") || inputt.Equals("y"))
                        {
                            player.weapon = g;
                            player.currency = g.cost;
                            g.cost = 0;
                            bought = true;
                        }
                        if (inputt.Equals("N") || inputt.Equals("n"))
                        {
                            bought = false;
                        }
                    }
                }
                
            }
            else if (input.Equals("A") || input.Equals("a"))
            {
                
                player.printStats();
                Console.WriteLine("Write stat to improve");
                Console.WriteLine("str");
                Console.WriteLine("con");
                Console.WriteLine("atk");
                Console.WriteLine("def");
                Console.WriteLine("hp");
                Console.WriteLine("sp");
                String statinput = Console.ReadLine();

                if (statinput.Equals("str"))
                {
                    Console.WriteLine("2 currency per point upgraded.");
                    Console.WriteLine("Currency available: " + player.currency);
                    int maxIncrease = (int)((double)player.currency) / 2;
                    Console.WriteLine("amount to improve by: (MAX: " + maxIncrease + ")");
                    Boolean shopped = false;
                    while (!shopped)
                    {
                        Console.WriteLine("(MAX: " + maxIncrease + " given current currency amount)");
                        statinput = Console.ReadLine();
                        int curinput = Int32.Parse(statinput);
                        while (!(curinput > maxIncrease))
                        {
                            player.str += curinput;
                            player.currency = player.currency - curinput;
                            shopped = true;
                            break;
                        }
                    }
                }
                else if (statinput.Equals("con"))
                {
                    Console.WriteLine("2 currency per point upgraded.");
                    Console.WriteLine("Currency available: " + player.currency);
                    int maxIncrease = (int)((double)player.currency) / 2;
                    Console.WriteLine("amount to improve by: (MAX: " + maxIncrease + ")");
                    Boolean shopped = false;
                    while (!shopped)
                    {
                        Console.WriteLine("(MAX: " + maxIncrease + " given current currency amount)");
                        statinput = Console.ReadLine();
                        int curinput = Int32.Parse(statinput);
                        while (!(curinput > maxIncrease))
                        {
                            player.con += curinput;
                            player.currency = player.currency - curinput;
                            player.hp = player.hpMax;
                            shopped = true;
                            break;
                        }
                    }
                }
                else if (statinput.Equals("atk"))
                {
                    Console.WriteLine("2 currency per point upgraded.");
                    Console.WriteLine("Currency available: " + player.currency);
                    int maxIncrease = (int)((double)player.currency) / 2;
                    Console.WriteLine("amount to improve by: (MAX: " + maxIncrease + ")");
                    Boolean shopped = false;
                    while (!shopped)
                    {
                        Console.WriteLine("(MAX: " + maxIncrease + " given current currency amount)");
                        statinput = Console.ReadLine();
                        int curinput = Int32.Parse(statinput);
                        while (!(curinput > maxIncrease))
                        {
                            player.atk += curinput;
                            player.currency = player.currency - curinput;
                            shopped = true;
                            break;
                        }
                    }
                }
                else if (statinput.Equals("def"))
                {
                    Console.WriteLine("2 currency per point upgraded.");
                    Console.WriteLine("Currency available: " + player.currency);
                    int maxIncrease = (int)((double)player.currency) / 2;
                    Boolean shopped = false;
                    while (!shopped)
                    {
                        Console.WriteLine("(MAX: " + maxIncrease + " given current currency amount)");
                        statinput = Console.ReadLine();
                        int curinput = Int32.Parse(statinput);
                        while (!(curinput > maxIncrease))
                        {
                            player.def += curinput;
                            player.currency = player.currency - curinput;
                            shopped = true;
                            break;
                        }
                    }
                }
                else if (statinput.Equals("sp"))
                {
                    Console.WriteLine("1 currency per point upgraded.");
                    Console.WriteLine("Currency available: " + player.currency);
                    int maxIncrease = (int)((double)player.currency) / 2;
                    Boolean shopped = false;
                    while (!shopped)
                    {
                        Console.WriteLine("(MAX: " + maxIncrease + " given current currency amount)");
                        statinput = Console.ReadLine();
                        int curinput = Int32.Parse(statinput);
                        while (!(curinput > maxIncrease))
                        {
                            player.sp += curinput;
                            player.currency = player.currency - curinput;
                            player.hp = player.hpMax;
                            shopped = true;
                            break;
                        }
                    }
                }
                else if (statinput.Equals("hp"))
                {
                    Console.WriteLine("1 currency per point upgraded.");
                    Console.WriteLine("Currency available: " + player.currency);
                    int maxIncrease = (int)((double)player.currency) / 2;
                    Boolean shopped = false;
                    while (!shopped) {
                        Console.WriteLine("(MAX: " + maxIncrease + " given current currency amount)");
                        statinput = Console.ReadLine();
                        int curinput = Int32.Parse(statinput);
                        while (!(curinput > maxIncrease))
                        {
                            player.hpMax += curinput;
                            player.currency = player.currency - curinput;
                            player.hp = player.hpMax;
                            shopped = true;
                            break;
                        }
                    }
                }

            }
            else if (input.Equals("B") || input.Equals("b"))
            {
                fightBattle(player);
            }

        }
        
       

    }
    static void fightBattle(Character player) {
        Battle b;
        Character opponent;
        Random rand = new Random();
        int roundno = 0;
        String[] opponentNameList =
            {
                "Svartepetter",
                "Pelle Skräck",
                "David Död",
                "Fredrik Förgörare",
                "Carolyn Combat",
                "Sven Skjutjärn",
                "Enögde Ingvor",
                "Harald Blåtand",
                "Peter Port",
                "Karl Johansson",
                "Sött från Grövgatan",
                "Store rök",
                "Piotr Pulaski",
                "Sillen",
                "Sulan",
                "Illern",
                "Benny Bone",
                "T-Bone Fernandez",
                "Arvid Automatkarbin",
                "Camilla Combat",
                "Vässlan",
                "Magnus M14",
                "Gurkan",
                "47an Löken",
                "Smärt-Sara",
                "Tjock-Stefan",
                "Kajsa Kalashnikov",
                "Vera Vodka",
                "Martin Molotov",
                "Bella Baseballträ",
                "Lennart Bladh",
                "Namnlöse Niklas",
                "Pelle Prutt",
                "Pekka Niv-och-Prit",
                "Allan A-lagare",
                "Sevan Slivovica",
                "Gjörgy Laszlo Magyarszag",
                "Maraton Lop"
            };
        while (true)
        {
            opponent = new Character(opponentNameList[rand.Next(opponentNameList.Length)], 25, 50);
            b = new Battle(player, opponent);
            roundno++;
            while (!b.isBattleOver())
            {
                if (player.sp <= 0) {
                    Console.WriteLine("Too tired to fight! Buy SP in stat store.");
                    return;
                    
                }
                b.fight();
                Thread.Sleep(1000);
            }
            if (!player.isDead())
            {
                Console.WriteLine("Fight won! press R to Retire, M for main menu or C to continue?");
                String input = Console.ReadLine();
                if (input.Equals("C") || input.Equals("c"))
                {
                    Console.Clear();
                }
                else if (input.Equals("R") || input.Equals("r"))
                {
                    Console.Clear();
                    b.printBattleLog();
                    player.printStats();
                    break;
                }
                else if (input.Equals("M") || input.Equals("m"))
                {
                    return;
                }
            }
            else if (player.isDead())
            {

                Console.WriteLine("Player is Dead!!! Press Y to read battle log and stats, press X to exit");
                Console.WriteLine("Final score: " + player.score);
                String s = Console.ReadLine();
                if (s.Equals("Y") || s.Equals("y"))
                {
                    Console.Clear();
                    b.printBattleLog(); // fix so this prints all battle logs
                    player.printStats();
                    System.Environment.Exit(0);
                }
                else
                if (s.Equals("X") || s.Equals("x"))
                {
                    System.Environment.Exit(0);
                }
            }
        }
    }

}
class Gear {
    static int counter = -1;
    int id;
    public String name;
    public int damage;
    public int cost;
    static LinkedList<Gear> list = new LinkedList<Gear>();
    private Gear(String nname, int ddamage, int ccost) {
        id = counter++;
        damage = ddamage;
        cost = ccost;
        name = nname;
        list.AddLast(this);
    }
    public static Gear createNewGear(String name, int lseed,int hseed) { 
        Random r = new Random();
        Gear g = new Gear (name, r.Next(lseed,hseed), r.Next(lseed,hseed));
        
        return g;
    
    }
    public static Gear emptyGear() {
        foreach (Gear g in list) {
            if (g.name.Equals("Empty"))
            {
                return g;
            }
        }
        Gear ag = createNewGear("Empty", 0, 0);
        return ag;
    }
    public static Gear getGear(String name) {
        foreach (Gear g in list) {
            if (g.name.Equals(name))
            {
                return g;
            }
        }
        Console.WriteLine("Gear not found! Returning empty gear.");
        return emptyGear();
    }
    public static String getListOfGear() {
        String s = "";
        foreach (Gear g in list) {
            String ss = "Namn: " + g.name + " Kostnad: " + g.cost + " Damage:" + g.damage + "\n";
            s += ss;
        }
        return s;
    
    }



}
class Character {

    public String name;
    static int counter = -1;
    int id;
    Random r;
    public int str;
    public int con;
    public int atk;
    public int def;
    public int score;
    public int hp;
    public int sp;
    public int currency;
    public Gear weapon;
    public int hpMax;

    public Character(String startingname) { 
        name = startingname;
        r = new Random();
        id = counter++;
        str = r.Next(100);
        con = r.Next(100);
        atk = r.Next(100);
        def = r.Next(100);
        hp = 100;
        sp = 100;
        score = 0;
        currency = 0;
        weapon = Gear.emptyGear();
        hpMax = 100;

    }
    public Character(String startingname,int lower, int upper)
    {
        name = startingname;
        r = new Random();
        id = counter++;
        str = r.Next(lower,upper);
        con = r.Next(lower,upper);
        atk = r.Next(lower, upper);
        def = r.Next(lower, upper);
        hp = 100;
        sp = 100;
        score = 0;
        currency = 0;
        weapon = Gear.emptyGear();
        hpMax = 100;

    }
    public Character(String startingname, int lower, int upper, int ccurrency)
    {
        name = startingname;
        r = new Random();
        id = counter++;
        str = r.Next(lower, upper);
        con = r.Next(lower, upper);
        atk = r.Next(lower, upper);
        def = r.Next(lower, upper);
        hp = 100;
        sp = 100;
        score = 0;
        currency = ccurrency;
        weapon = Gear.emptyGear();
        hpMax = 100;

    }
    public Boolean isDead() {
        if (hp <= 0)
        {
            return true;
        }
        return false;

    }
    public void printStats() {
        Console.WriteLine();
        Console.WriteLine("score " + this.score);
        Console.WriteLine("hp " + this.hp + "/"+this.hpMax+ "Health Points"); // add hp in store
        Console.WriteLine("str " + this.str +" Improves damage");
        Console.WriteLine("atk " + this.atk + " Improves damage"); 
        Console.WriteLine("con " + this.con + " Improves HP regen between fights"); 
        Console.WriteLine("def " + this.def + " Mitigates damage taken"); // add def mitigating damage
        Console.WriteLine("sp " + this.sp + " Determines how often " + this.name +" can fight.");
        Console.WriteLine("Currency " + this.currency);
        Console.WriteLine("Weapon: " + this.weapon.name);
        Console.WriteLine();
    }
    public void rechargeHP() {
        hp += r.Next(con / 8, con / 4);
        if (hp > hpMax) {
            hp = hpMax;
        }
    }

}
class Battle {
    Character char0;
    Character char1;
    LinkedList<Round> rounds;
    Round N;
    public static LinkedList<Battle> battles = new LinkedList<Battle>();
    public Battle(Character i, Character j) {
        this.char0 = i;
        this.char1 = j;
        char1.rechargeHP();
        char0.rechargeHP();
        rounds = new LinkedList<Round>();


    }
    public void fight()
    {
        if (isBattleOver()) {
            return;
        }
        if (char0.con - 5 < 0) {
            Console.WriteLine("Not enough CON to fight! Buy more in stat store.");
            return;
        }
        while (true) {
            if (isBattleOver()) {
                if (char0.isDead() && char1.isDead())
                {
                    
                    Console.WriteLine("Both are dead!");
                    battles.AddLast(this);
                    char0.sp -= 5;
                    if (char0.sp < 0)
                    {
                        char0.sp = 0;
                    }
                    return;
                }
                else if (char0.isDead())
                {
                    
                    Console.WriteLine("Player is dead!");
                    battles.AddLast(this);
                    char0.sp -= 5;
                    if (char0.sp < 0) {
                        char0.sp = 0;
                    }
                    return;
                }
                else if (char1.isDead()) {
                    char0.score += 100;
                    Console.WriteLine("Opponent is dead!");
                    battles.AddLast(this);
                    char0.sp = char0.sp - 5;
                    if (char0.sp < 0)
                    {
                        char0.sp = 0;
                    }
                    char0.currency +=  10;
                    return;
                }
            }
            N = new Round(char0,char1);
            N.roll();
            rounds.AddLast(N);
            Console.WriteLine(N.getRoundMessage());
            Console.WriteLine();
        }
    }
    public Boolean isBattleOver() {
        if (char0.isDead() || char1.isDead()) {
            return true;
        }
        return false;
    }

    public void printBattleLog() {
        foreach (Battle battle in battles) { 
            foreach (Round round in battle.rounds) {
                Console.WriteLine(round.getRoundMessage());
            } 
        }
    }

}

class Round {
    Random r;
    Character char0;
    Character char1;
    String roundMessage;
    public Round(Character i,Character j) { 
        r = new Random();
        char0 = i;
        char1 = j;
    }
    public void roll() {
        
            if (char0.isDead() || char1.isDead()) {
                return;
            } 
            int char0Roll = r.Next((int)Math.Ceiling((decimal)(char0.atk + char0.str)/16), (int)Math.Ceiling((decimal)(char0.atk + char0.str) / 8));
            int char1Roll = r.Next((int)Math.Ceiling((decimal)(char0.atk + char0.str) / 16), (int)Math.Ceiling((decimal)(char0.atk + char0.str) / 8));
            char1.hp -= char0Roll + char0.weapon.damage - r.Next((int)Math.Ceiling((decimal)(char0.def/10)), (int)Math.Ceiling((decimal)(char0.def / 5)));// If char0 has 99 attack char1 will lose between 1-25 hp
            char0.hp -= char1Roll + char1.weapon.damage - r.Next((int)Math.Ceiling((decimal)(char1.def / 10)), (int)Math.Ceiling((decimal)(char1.def / 5)));
            roundMessage = char0.name + " hits " + char1.name + " for " + char0Roll + " damage\n" 
                + char1.name + " hits " + char0.name + " for " + char1Roll + " damage\n" 
                + char0.name + " HP left: " + char0.hp + " " + char1.name + " HP left: " + char1.hp + "\n";
        Thread.Sleep(500);
    }
    public String getRoundMessage() {
        return roundMessage;
    }

}