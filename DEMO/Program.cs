using System.Collections;

internal class Program
{


    public static int SumArrayList(ArrayList arrayList)
    {

        int sum = 0;
        if (arrayList is not  null)        
            for (int i = 0; i < arrayList.Count; i++)
                sum += (int)arrayList[i];
        return sum;
    
    
    
    }

    private static void Main(string[] args)
    {
        #region Non Generic Collection
        //ArrayList arrayList = new ArrayList();
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");

        //arrayList.Add( 1 );
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");

        //arrayList.AddRange( new int[] { 3,4} );
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");

        //arrayList.Add(5);
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");





        //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");
        //arrayList.Add(6);
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");
        //arrayList.TrimToSize();
        //Console.WriteLine($"Count of array liist = {arrayList.Count} , {arrayList.Capacity}");
        //arrayList.Add(1);
        ////arrayList.Add("kerollos");


        //int  result = SumArrayList(arrayList);
        //Console.WriteLine(result);

        //foreach(int i in arrayList)
        //Console.WriteLine(i); 
        #endregion


        #region Generic Collection
        //List<int> list = new List<int>();
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //list.Add(1);
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //list.Add(2);
        //list.AddRange(new int[] { 3, 4 });
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //list.Add(5);
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //list.TrimExcess();
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");



        //List<int> list = new List<int>(5) {1,2,3,4,5 };
        ////Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //list.Add(6);
        ////Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");

        //foreach (int i in list) 
        //    Console.Write(  i+" ,");
        //Console.WriteLine();
        //list[3] = 45;
        //for (int i = 0;i < list.Count;i++)
        //    Console.Write(list [i] + " ," );

        #endregion


        #region List Methods
        //List<int> list = new List<int>(4) { 1,2,3,4};
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //list.Add(5);
        //list.AddRange(new int[] { 6, 7 });
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //foreach (int i in list) Console.Write(  i +" ,");
        //Console.WriteLine();
        //list.Insert(6, 2);
        //foreach (int i in list) 
        //    Console.Write(  i +" ,");  
        //list.InsertRange(4,new int[] { 9,50});
        //Console.WriteLine();
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //foreach (int i in list) 
        //    Console.Write(  i +" ,");
        //Console.WriteLine();

        //int index = list.BinarySearch(90);
        //Console.WriteLine(index);
        //Console.WriteLine();
        //list.Clear();
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");
        //Console.WriteLine(list.Contains(9));

        //List<int> list = new List<int>(5) { 1, 2, 3, 4 };
        //int[] ints = new int[10];
        //list.CopyTo(ints);
        //list.CopyTo(ints, 3);
        //list.CopyTo(1,ints,5,3);
        //foreach (int i in ints)
        //    Console.Write((i)+" ,");
        //list.EnsureCapacity(15);
        //Console.WriteLine($"Count of array list = {list.Count} , {list.Capacity}");


        //List<int> list = new List<int>(10) { 1, 2, 3, 4 ,56,6,4,8,45};
        //int index = list.IndexOf(3);
        //Console.WriteLine(index);
        //
        //list.Remove(4);
        //foreach (int i in list)
        //    Console.WriteLine(i); 
        #endregion

        #region Linked List
        //LinkedList<int> ints = new LinkedList<int>();
        //Console.WriteLine(ints.Count);

        //ints.AddFirst(1);
        //Console.WriteLine(ints.Count);

        //ints.AddLast(1);
        //Console.WriteLine(ints.Count);

        //LinkedListNode<int> ints1 = ints.Find(1);
        //ints.AddAfter(ints1, 1);
        //Console.WriteLine(ints.Count); 
        #endregion




        #region Stack
        //Stack<int> stack = new Stack<int>();
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);

        //Console.WriteLine(stack.Peek());

        //Console.WriteLine();
        //foreach (int i in stack)
        //    Console.WriteLine(i);


        //Console.WriteLine();
        //Console.WriteLine(stack.Pop());
        //foreach (int i in stack)
        //    Console.WriteLine(i);



        //bool result = stack.TryPop(out int Element);

        //Console.WriteLine(result);
        //Console.WriteLine(Element); 
        #endregion















    }
}