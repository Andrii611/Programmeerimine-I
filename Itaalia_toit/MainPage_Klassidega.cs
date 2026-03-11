namespace Itaalia_toit
{
    public class MainPage_klassidega
    {
        public static void Main(string[] args)
        {
            bool tootab = true;
            {
                Console.WriteLine("Funktsioonid");
                string valik = Console.ReadLine();
                switch (valik)
                {
                    case "1": Itaalia_funktsioonid_klassidega.LaeAndmedFailist(); break;
                    case "2": Itaalia_funktsioonid_klassidega.ItaaliaRestoran(); break;
                    case "3":
                        Itaalia_funktsioonid_klassidega.LiisaUusToit(); break;
                }
            }

        }
    }
}
