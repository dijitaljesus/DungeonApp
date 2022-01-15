namespace DungeonApp
{

    class Save
    {

        public static void SaveXML()
        {

            Character player = new Character();
            player.Name = "Bob the Dragon Slayer";
            player.Health = 100;
            player.Race = "Elf";
            player.Strength = 7;
            player.WeightCapacity = 10;

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Character));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, player);
            file.Close();

        }
    }


}