namespace Guns_of_the_Olds_West.Models
{
    public class PartyModel
    {
        public int BulletsRemaining { get; set; }

        public int MoneySpent { get; set; }

        public int numberPicked;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime DateOfTheParty { get; set; }


        private static PartyModel? instance;

        public PartyModel() {
            BulletsRemaining = 12;
            MoneySpent = 0;
        }

        public static PartyModel getInstance()
        {
            if (instance == null)
            {
                return instance = new PartyModel();
            }
            else
            {
                return instance;
            }
        }

        public void Shoot()
        {
            BulletsRemaining--;
            numberPicked = new Random().Next(0, 10);
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
