using System;

class Program
{
    static void Main(string[] args)
    {
        
        string[] inputs = Console.ReadLine().Split();
        
        int A = int.Parse(inputs[0]); 
        int B = int.Parse(inputs[1]); 
        int C = int.Parse(inputs[2]); 
        int D = int.Parse(inputs[3]); 

 
        int shuttleTime = A + B; 
        int walkTime = C;       

        bool canShuttle = shuttleTime <= D;
        bool canWalk = walkTime <= D;

        
        if (canShuttle && canWalk)
        {
            Console.WriteLine("~.~");
        }
        else if (canShuttle)
        {
            Console.WriteLine("Shuttle");
        }
        else if (canWalk)
        {
            Console.WriteLine("Walk");
        }
        else
        {
            Console.WriteLine("T.T");
        }
    }
}