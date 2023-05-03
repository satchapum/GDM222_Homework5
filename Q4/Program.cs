class Program
{
    static void Main()
    {
        int rows = 1;
        int colums = 1;
        //something such
        Stack<int> undo = new Stack<int>();
        while(true)
        {
            int action = int.Parse(Console.ReadLine());
            if(action == 11)
            {
                break;
            }
            bool isMove = false;
            
            //aditional of 9 & 10
            if(action == 10)
            {

            }

            if(!isMove)
            {
                continue;
            }
            Move(action, ref rows, ref colums);
        }

        Console.WriteLine(Convert.ToChar(rows-1+'A')+" "+colums);
    }
    static bool CheckMove(int action, ref int rows, ref int colums)
    {
        if(action == 1)
        {
            if(rows+1 <= 8)
            {
                return true;
            }
            else if(rows + 1 <= 8 && colums - 1 > 0)
            {

            }
            else if(colums - 1 > 0)
            {
                return true;
            }
            else if(rows - 1 > 0 && colums - 1 > 0)
            {
                return true;
            }
            else if(rows - 1 > 0)
            {
                return true;
            }
            else if(rows - 1 > 0 && colums + 1 <= 8)
            {
                return true;
            }
            else if(colums + 1 <= 8)
            {
                return true;
            }
            else if(rows + 1 <= 8 && colums + 1 <= 8)
            {
                return true;
            }
        }
        return false;
    }
    static void Move(int action, ref int rows, ref int colums)
    {
        if(action == 1)
        {
            if(rows+1 <= 8)
            {
                rows++;
            }
            else if(rows + 1 <= 8 && colums - 1 > 0)
            {
                rows++;
                colums--;
            }
            else if(colums - 1 > 0)
            {
                colums--;
            }
            else if(rows - 1 > 0 && colums - 1 > 0)
            {
                rows--;
                colums--;
            }
            else if(rows - 1 > 0)
            {
                rows--;
            }
            else if(rows - 1 > 0 && colums + 1 <= 8)
            {
                colums++;
            }
            else if(colums + 1 <= 8)
            {
                colums++;
            }
            else if(rows + 1 <= 8 && colums + 1 <= 8)
            {
                rows++;
                colums++;
            }
        }
    }
}