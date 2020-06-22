using System;

namespace CSharpTree
{
    class SampleSearching
    {
        static void Main(string[] args)
        {
           // TreeNode<int> treeRoot = SampleData.GetSet1();
            var Result = SampleIterating.GetSum().ToString();
            Console.WriteLine("Sum: " + Result);
        }
    }
}
