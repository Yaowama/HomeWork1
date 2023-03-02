class Program {
    static void Main(string[] args) {
        Console.Write("Input password (6 digits) : ");
        int password = int.Parse(Console.ReadLine());
        int p6 = (int)password/100000;
        password = password - p6 * 100000;
        int p5 = (int)password/10000;
        password = password - p5 * 10000;
        int p4 = (int)password/1000;
        password = password - p4 * 1000;
        int p3 = (int)password/100;
        password = password - p3 * 100;
        int p2 = (int)password/10;
        password = password - p2 * 10;
        int p1 = (int)password/1 ;
        password = password - p1 * 1;       

        if (password >= 0) {
            Console.Write("Input agency code : ");
            string agency = Console.ReadLine();

            if (agency == "CIA") {
                if (p1 % 3 == 0 && p2 != 1 && p2 != 3 && p2 != 5 && p4 >= 6 && p4 != 8 ) { 
                    Console.WriteLine("True");
                } else {
                    Console.WriteLine("False"); } 
            } 
        
            if (agency == "FBI") {
                if ((p6 >= 4 && p6 <= 7) && (p3 % 2 == 0 && p3 != 6) && (p5 % 2 != 0)) { 
                    Console.WriteLine("True");
                } else {
                    Console.WriteLine("False"); } 
            } 

            if (agency == "NSA") {
                if (30 % p1 == 0 && p3 % 3 == 0 && p3 % 2 != 0 && (p2 == 7 || p4 ==7 || p5 == 7 || p6 == 7)) { 
                    Console.WriteLine("True");
                } else {
                    Console.WriteLine("False"); } 
            } 
            else {
                Console.WriteLine("False"); }
        } 
    }
}
