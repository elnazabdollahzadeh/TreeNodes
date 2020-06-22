using System;
using System.Text;

namespace CSharpTree
{
    public class SampleIterating
    {
        public static int GetSum()
        {
            TreeNode<int> treeRoot = SampleData.GetSet1();
            int SumOfNodes = 0;
            foreach (TreeNode<int> node in treeRoot)
            {
                SumOfNodes += node.Data;
            }
            return SumOfNodes;
        }

    }
}
