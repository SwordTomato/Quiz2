class Program {
    static int Max(int result,int B) {
        if(result > b) {
            int b = result;
            return result;
        }  return b;

    }

    static int Min(int result,int B) {
        if(result < b) {
            int b = result;
            return result;
        }  return b;

    }

    static int Mean(int result,int B) {
        

    }
    static void Main(string[] args) {
        
       while(true) {
        string num = (Console.ReadLine());

        if(num == "End") {
            break;
        }
        int result = Int32.Parse(num);
        int B = 1;
        int FindMax = Max(result,B);
       }
            string num = (Console.ReadLine());
       string Order = (Console.ReadLine());
                if(Order == "FindMax") {
                    Console.WriteLine(FindMax);
                } if(Order == "FindMin") {
                    Console.WriteLine("b");
                } if(Order == "FindMean") {
                    Console.WriteLine("c");
                } else {
                    Console.WriteLine("Invalid mode");
                }   
       

        //int result1 = Max4(2 , 7, 1, 3);
        //int result2 = Max4(6 , 8, 1, 2);
        //int FinalResult = Max(result1,result2);
        //Console.WriteLine("{0}", FinalResult);
    }
}  