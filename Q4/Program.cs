class Program
{
    static void Main()
    {
        int rows = 1;
        int colums = 1;
        Stack<Tuple<int, int>> undoStack = new Stack<Tuple<int, int>>();
        Stack<Tuple<int, int>> redoStack = new Stack<Tuple<int, int>>();

        while(true)
        {
            int move = int.Parse(Console.ReadLine());
            int x;
            bool canMove = false;

            if(move==11)
            {
                break;
            }
            else if(move==9 && undoStack.Count>0){
                Tuple<int,int> temp = new Tuple<int,int>(rows,colums);
                rows=undoStack.Peek().Item1; 
                colums=undoStack.Peek().Item2;  
                redoStack.Push(temp); undoStack.Pop();
                continue;
            }
            else if(move==10 && redoStack.Count>0){
                Tuple<int,int> temp = new Tuple<int,int>(rows,colums);
                rows=redoStack.Peek().Item1; 
                colums=redoStack.Peek().Item2;
                undoStack.Push(temp); redoStack.Pop();
                continue;
            }
            else if(move!=9&&move!=10){ x = int.Parse(Console.ReadLine());
                canMove = CheckMove(move,rows,colums,x);

                if(!canMove){continue;}
                Tuple<int,int> temp = new Tuple<int,int>(rows,colums);
                undoStack.Push(temp);
                Move(move,ref rows,ref colums,x); 
                while(redoStack.Count>0){redoStack.Pop();}
            }
        }

        Console.WriteLine(Convert.ToChar(colums-1+'A')+" "+rows);
    }
    static bool CheckMove(int action, int rows, int colums,int x)
    {
        if(action == 1)
        {
            if(rows + x <= 8)
            {
                return true;
            }
        }
        else if(action == 2)
        {
            if(rows + x <= 8 && colums - 1 > 0)
            {
                return true;
            }
        }
        else if(action == 3)
        {
            if(colums - x > 0)
            {
                return true;
            }
        }
        else if(action == 4)
        {
            if(rows - x > 0 && colums - x > 0)
            {
                return true;
            }
        }
        else if(action == 5)
        {
            if(rows - x > 0)
            {
                return true;
            }
        }
        else if(action == 6)
        {
            if(rows - x > 0 && colums + x <= 8)
            {
                return true;
            }
        }
        else if(action == 7)
        {
            if(colums + x <= 8)
            {
                return true;
            }
        }
        else if(action == 8)
        {
            if(rows + x <= 8 && colums + x <= 8)
            {
                return true;
            }
        }
        else
        {
            return false;
        }
        return false;
    }
    static void Move(int action, ref int rows, ref int colums, int x)
    {
        if(action == 1)
        {
            if(rows + x <= 8)
            {
                rows +=x ;
            }
        }
        else if(action == 2)
        {
            if(rows + x <= 8 && colums - 1 > 0)
            {
                rows += x;
                colums -= x;
            }
        }
        else if(action == 3)
        {
            if(colums - x > 0)
            {
                colums -= x;
            }
        }
        else if(action == 4)
        {
            if(rows - x > 0 && colums - x > 0)
            {
                rows -= x;
                colums -= x;
                
            }
        }
        else if(action == 5)
        {
            if(rows - x > 0)
            {
                rows -= x;
            }
        }
        else if(action == 6)
        {
            if(rows - x > 0 && colums + x <= 8)
            {
                rows -= x;
                colums += x;
            }
        }
        else if(action == 7)
        {
            if(colums + x <= 8)
            {
                colums += x;
            }
        }
        else if(action == 8)
        {
            if(rows + x <= 8 && colums + x <= 8)
            {
                rows += x;
                colums += x;
            }
        }
    }
}