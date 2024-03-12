namespace Guns_of_the_Olds_West.Models
{
    public class PartyModel
    {
        public int BulletsRemaining { get; set; }

        public int MoneySpent { get; set; }

        private int numberPicked;

        public PartyModel() {
            BulletsRemaining = 12;
            MoneySpent = 0;
        }

        public void Shoot()
        {
            BulletsRemaining--;
            numberPicked = new Random().Next(0, 10);
            if (numberPicked < 4)
            {
                /* Lancer code "On a gagné */
            }
        }

        public void Reload2()
        {
            BulletsRemaining += 2;
            MoneySpent += 1;
        }

        public void Reload7()
        {
            BulletsRemaining += 7;
            MoneySpent += 4;
        }

        public void Reload12()
        {
            BulletsRemaining += 12;
            MoneySpent += 7;
        }
    }
}
