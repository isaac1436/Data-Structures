using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class CustomLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddItem(T item)
        {
            if (Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item, temp);
                Tail.NextNode = newNode;
                Tail = newNode;
            }
        }

        public void AddNode(ListNode<T> node)
        {
            if (Head is null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.NextNode = node;
                Tail = node;
            }

        }

        public T AddFirst(int count)
        {
            dynamic sum=Head.Value;
            dynamic currNode = sum;
            for(int i=0;i<count-1; i++)
            {
                sum +=currNode.NextNode.Value; 
                currNode=currNode.NextNode;
            }
            return sum;
        }

        public T AddLast(int count)
        {
            dynamic sum = Tail.Value;
            dynamic currNode = sum;
            for (int i = 0; i < count-1; i++)
            {
                sum += currNode.PreviousNode.Value;
                currNode = currNode.PreviousNode;
            }
            return sum;
        }

        public int find(ListNode<T> node)
        {
            int indexof=-1;
            dynamic currNode=Head;

            for(int i=0; ; i++)
            {
                if (currNode == node.Value)
                {
                    indexof = i;
                    break;
                }

                else if (currNode == null)
                {
                    break;
                }

                currNode = currNode.NextNode;
            }
            return indexof;
        }

        public void remove(ListNode<T> node)
        {
            dynamic currNode = Head;
            for(int i=0; ; i++)
            {
                if (currNode==node.Value)
                {
                    currNode = null;
                    break;
                }

                else
                {
                    currNode = currNode.NextNode;
                }
            }


        }


        public void clear(ListNode<T> currNode)
        {
            if(currNode == null)
            {
                return;
            }

            else
            {
                currNode = null;
                clear(currNode.NextNode);
            }
        }
    }
}
