namespace DungeonApp {

class Gold {

    private static int _amount;
    private static double _weight = 0.01;
    
    public static void Increase(int amount) {
        _amount += amount;
        Console.WriteLine("{0} gold pieces have been added to your gold pouch, you now have {1} gold.", amount, _amount);
    }

    public static void Decrease(int amount) {
        _amount -= amount;
        Console.WriteLine("{0} gold pieces have been taken from your gold pouch, you now have {1} gold.", amount, _amount);
    }

    public static int Amount() {
        return _amount;
    }

    public static int Weight() {
        return Convert.ToInt32((Convert.ToDouble(_amount) * _weight));
    }

}

}