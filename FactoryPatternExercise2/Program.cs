namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string reply;
            bool inputCheck = false;
            do
            {
                Console.WriteLine("Hello, Which database would you want to work with?");
                Console.WriteLine("Please enter either 'sql' 'mongo' or 'list'.");
                reply = Console.ReadLine();
                
                if (reply.ToLower() != "sql" && reply.ToLower() != "list" && reply.ToLower() != "mongo")
                {
                    Console.WriteLine("Please enter a valid selection.");
                }
                else
                {
                    inputCheck = true;
                }
                
            } while (!inputCheck);
            var db = DataAccessFactory.GetDataAccessType(reply);

            var products = db.LoadData();
            db.SaveData();

            foreach ( var product in products )
            {
                Console.WriteLine($"Item Name: {product.Name} Item Price: {product.Price}");
            }

        }
    }
}
