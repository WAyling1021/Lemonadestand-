using System;
namespace LemonadeStand
{
    public class Store
    {
        private readonly object console;

        //member variables (Has A)
        double cupPrice;
        double waterPrice;
        double icePrice;
        double lemonPrice;
        double sugarPrice;


        // constructor (Spawner)
        public Store()
        {
            cupPrice = .50;
            waterPrice = .10;
            icePrice = .5;
            lemonPrice = .45;
            sugarPrice = .35;
        }


        // member methods
       
        public void BuyItem()
        {
            UserInterface ui = new UserInterface();

            string itemToBuy = ui.ItemToBuy();
            switch (itemToBuy)
            {
                case "cup":
                case "cups":
                    //player spends money
                    //player.cash -= whatever the cost of a cup is
                    Console.WriteLine("");
                    break;
                case "water"
                    //player spends money
                    //player.cash -= whatever the cost of water is
                    Console.WriteLine("");
                    break;
                case "ice":
                    //player spends money
                    //player.cash -= whatever the cost of ice is
                    Console.WriteLine("");
                    break;
                case "lemon":
                case "lemons":
                    //player spends money
                    //player.cash -= whatever the cost of lemons is 
                    Console.WriteLine("");
                    break;
                case "sugar":
                    //player spends money
                    //player.cash -= whatever the cost of sugar is
                    Console.WriteLine("");
                    break;

            }



        }
}
