using System;

namespace Kerusakan_Part_02
{
    class Program
    {
        static Random acak = new Random();
        static void Main(string[] args)
        {
            SwordDamage kpdn = new SwordDamage(LemparDadu(3));
            ArrowDamage kpnh = new ArrowDamage(LemparDadu(1));

            bool bener = true;

            while (bener)
            {
                Console.Write("0: NO MAGIC/FLAMING, 1: MAGIC, 2: FLAMING, " +
                                "3. BOTH, anything else: Quit: ");

                char key = Console.ReadKey().KeyChar;

                if (key != '0' && key != '1' && key != '2' && key != '3') return; 
                //if (key != '0' || key != '1' || key != '2' || key != '3') return;

                Console.Write("\nS: Sword, A: Arrow, anything else: Quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                //switch (key)
                //{
                //    case '0':
                //        takeSWitch('0', weaponKey, kpdn, kpnh);
                //        break;
                //    case '1':
                //        takeSWitch('1', weaponKey, kpdn, kpnh);
                //        break;
                //    case '2':
                //        takeSWitch('2', weaponKey, kpdn, kpnh);
                //        break;
                //    case '3':
                //        takeSWitch('3', weaponKey, kpdn, kpnh);
                //        break;
                //    default:
                //        return;
                //       // break; <--break unecessary

                //}
                switch (weaponKey)
                {
                    case 'S':
                        kpdn.Roll = LemparDadu(3);
                        kpdn.Magic = (key == '1' || key == '3');
                        kpdn.Flaming = (key == '2' || key == '3');
                        Console.WriteLine(
                           $"\nRolled {kpdn.Roll} for {kpdn.Damage} HP\n");

                        break;

                    case 'A':
                        kpnh.Roll = LemparDadu(1);
                        kpnh.Magic = (key == '1' || key == '3');
                        kpnh.Flaming = (key == '2' || key == '3');
                        Console.WriteLine(
                           $"\nRolled {kpnh.Roll} for {kpnh.Damage} HP\n");
                        break;

                } //end switch

            } //END WHILE

           

        } //end Main method

        private static int LemparDadu(int banyakLemparan)
        {
            int total = 0;
            for (int i = 0; i < banyakLemparan; i++) total += acak.Next(1, 7);
            return total;
        } //end LemparDadu method


        //private static void takeSWitch (char key, char keyWeapon, SwordDamage kpdn, ArrowDamage kpnh)
        //{
        //    switch (keyWeapon)
        //    {
        //        case 'S':
        //            kpdn.Roll = LemparDadu(3);
        //            kpdn.Magic = (key == '1' || key == '3');
        //            kpdn.Flaming = (key == '2' || key == '3');
        //            Console.WriteLine(
        //               $"\nRolled {kpdn.Roll} for {kpdn.Damage} HP\n");

        //            break;

        //        case 'A':
        //            kpnh.Roll = LemparDadu(1);
        //            kpnh.Magic = (key == '1' || key == '3');
        //            kpnh.Flaming = (key == '2' || key == '3');
        //            Console.WriteLine(
        //               $"\nRolled {kpnh.Roll} for {kpnh.Damage} HP\n");
        //            break;

        //    } //end switch
        //}

    } //end class
} //end namespace
