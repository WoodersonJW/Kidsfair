namespace KidsFair
{
    class Pet
    {
        private string name; //Name of pet
        private int age; //age 
        private bool isFemale; //If female, otherwise false

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Greetings from the Pet Owner application"); //Greeting message
            Console.WriteLine(); //blankline

            ReadAndSavePetData();
            DisplayPetInfo();
        }
            public void ReadAndSavePetData() //Pet Data
            {
             //Read a line of text
             Console.WriteLine("What is the name of your pet?");
             name = Console.ReadLine();

             //Read a whole number
             Console.WriteLine("What is " + name + "'s age?");
             string textValue = Console.ReadLine();
             //convert string to number
             age = int.Parse(textValue);

             //Read a logical value (y/n)
             Console.WriteLine("Is your pet a female (y/n)?");
             string strGender = Console.ReadLine();
             strGender = strGender.Trim(); //Delete leading and trailing spaces
             char response = strGender[0];

             if ((response == 'y') || (response == 'Y'))
                isFemale = true;         
             else
                isFemale = false;
            }
                public void DisplayPetInfo()
                {
                 string textOut = "Name: " + name + " Age: " + age;
                 Console.WriteLine(textOut);
                }
          
    }
}
