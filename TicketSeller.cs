namespace KidsFair
{
    class TicketSeller
    {
        private string name; //Name of person
        private double price = 100;
        private int numOfAdults; //total of adults
        private int numOfChildren; //total of kids
        
        public void Start()
        {
         Console.WriteLine(); //blankline
         Console.WriteLine("Welcome to Kids Fair!"); //Greeting message
         Console.WriteLine("Children get 75% discount!"); //Discount info
         Console.WriteLine(); //blankline

         ReadAndSaveKidsFairData();
         DisplayKidsFairInfo();

        }
            public void ReadAndSaveKidsFairData() //Kids Fair Data
            {
             //Read a line of text
             Console.Write("Name:");
             name = Console.ReadLine();

             //Read a whole number adults
             Console.WriteLine("Number of adults:"); 
             string textValueAdult = Console.ReadLine();
             //convert string to number
             numOfAdults = int.Parse(textValueAdult);

             //Read a whole number kids
             Console.WriteLine("Number of kids:");
             string textValueChildren = Console.ReadLine();
             //convert string to number
             numOfChildren = int.Parse(textValueChildren);
            }
                public void DisplayKidsFairInfo()
                {
                 double totalPriceAdult = numOfAdults * price; //Total amount for adults to pay
                 double totalPriceChildren = numOfChildren * (price*.25); //Total amount for children to pay
                 double amountToPay = totalPriceAdult + totalPriceChildren;
                 Console.WriteLine(" +++ Amount to pay = " + amountToPay + " +++ ");
                 Console.WriteLine(" +++ Your receipt +++");
                 Console.WriteLine(" Thank you " + name + " and please come back! +++ ");
                }
    }            
}
