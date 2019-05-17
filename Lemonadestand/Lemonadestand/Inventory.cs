using System;
namespace LemonadeStand
{
    public class Inventory
       
        //member variables 
        public double cups;
        public double ice;
        public double sugar;
        public double lemons;

        // constructor (Spawner)
        public Inventory()
        public Inventory(double numberofCups, double numberofIce, double numberofSugar, double numberofLemons)
    {
        cups = numberofCups;
        ice = numberofCups;
        sugar = numberofSugar;
        lemons = numberofLemons;
    }

        // member methods
         public void ItemDecay()
         {

         cups--;
         ice--;
         sugar--;
         lemons--;
         
         }



}
}
