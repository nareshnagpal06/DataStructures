
namespace DS
{
    using System;
    public class BinarySearchTree
    {

        Node rootNode;

        public void Insert(string value)
        {

        }

        public bool find(string value)
        {
            
        }
    }

    private class Node
    {
        private string value;
        private Node leftChild;

        private Node rightChild;

        public Node(string value)
        {
            this.value = value;
        }

        public string Value { get { return value; } }


    }
}