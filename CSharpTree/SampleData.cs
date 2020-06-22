namespace CSharpTree
{
    class SampleData
    {
        public static TreeNode<int> GetSet1()
        {
            TreeNode<int> root = new TreeNode<int>(100);
            {
                TreeNode<int> node0 = root.AddChild(0);
                TreeNode<int> node1 = root.AddChild(1);
                TreeNode<int> node2 = root.AddChild(2);
                {
                    TreeNode<int> node20 = node2.AddChild(20);
                    TreeNode<int> node21 = node2.AddChild(21);
                    {
                        TreeNode<int> node210 = node21.AddChild(210);
                        TreeNode<int> node211 = node21.AddChild(211);
                    }
                }
                TreeNode<int> node3 = root.AddChild(3);
                {
                    TreeNode<int> node30 = node3.AddChild(30);
                }
            }

            return root;
        }
    }
}
