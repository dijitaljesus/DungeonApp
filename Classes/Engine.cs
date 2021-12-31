namespace DungeonApp
{
    class Engine
    {

        public static int RandomNumber(int min, int max) {
            
            Random random = new Random();
            return random.Next(min, max);

        }

        public void PlayerCreation() {

            string pName = "";
            while (pName == "") {
            Console.Write("Choose a Player Name: ");
            pName = "" + Console.ReadLine();
            }
            
            Console.Clear();

            Character myPlayer = new Character { Name = pName, Health = Engine.RandomNumber(50,100) };

            Console.WriteLine("Player Name: {0}", myPlayer.Name);
            Console.WriteLine("Health: {0}", myPlayer.Health);

        }


        public void Combat() {


            
        }

        public void Event() {

            int R = RandomNumber(1,5);

            switch (R) {

                case 1:
                Console.WriteLine("You come across an elf trader..");
                break;

                case 2:
                Console.WriteLine("You come to a cross roads, do you walk left or right?");
                break;

                case 3:
                Console.WriteLine("You come to a closed door, do you slowly open the door or barge your way in?");  
                break;

                case 4:
                Console.WriteLine("You come to a hole in the floor, the only way across is to jump.");
                break;

                case 5:
                Console.WriteLine("You come across a monster, on closer inspection you see it's a..");
                break;

            }

        }

    }
}