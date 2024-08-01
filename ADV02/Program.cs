using System.Collections;

internal class Program
{

    
    public static void ArraylistRevere(ArrayList arrays ) 
    {
        
        int left = 0;
        int right = arrays.Count -1;

        
      
        
            while (left  <right)
            {
                object  temp = arrays[left];
                arrays[left] = arrays[right];
                arrays[right] = temp;

                ++left;
                --right;

            }
       
        
        




    
    
    
    
    
    
    }

    public static List<int> listEvenNum(List<int> values)
    {
        List<int> num = new List<int>();
        foreach (int value in values)
            if(value %2 ==0)
            num.Add(value);
        return num;

    }

    public  class FixedSizeList<T>
    {
        public T[] Value{ get; set; }
        public int Count { get; set; }

        



        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }
            Value = new T[capacity];
            



        }

        public void Add(T value)
        {
            if (Count >= Value.Length)
            {
                throw new InvalidOperationException("List is full.");
            }
            Value[Count++] = value;
            
        }
        public T Get(int index)
        {
            if ( index >= Count)
            {
                throw new ArgumentOutOfRangeException($"{index} Index is out of range.");
            }
            return Value[index];
        }


    }

    public static void Main(string[] args)
    {


        #region Q1

        //ArrayList arrayLists = new ArrayList() { 1,2,3,4,5,6,7,8,9,14,15,16,17,18,19,20};

        //ArraylistRevere(arrayLists);

        //foreach (int i in arrayLists)
        //Console.Write(i +" "); 
        #endregion


        #region Q2

        //List<int> list = new List<int>()  { 1,2,3,4,5,6,7,8,9,10,11,12,13};        
        //foreach (int i in listEvenNum(list))
        //    Console.Write(i+" ,"); 
        #endregion





        #region Q3
        //var list = new FixedSizeList<int>(3);
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);


        //Console.WriteLine($"{list.Count} , {list.Value}");
        //Console.WriteLine(list.Get(2)); 
        #endregion








    }
}