namespace DungeonApp {

class Gold {

    private static int _amount;

    
    public static void Increase(int amount) {

        _amount += amount;

    }

    public static void Decrease(int amount) {

        _amount -= amount;

    }

    public static int Amount() {

        return _amount;

    }

}


}