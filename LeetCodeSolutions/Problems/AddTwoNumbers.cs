using LeetCodeSolutions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems
{
    /// <summary>
    /// Add Two Numbers
    /// https://leetcode.com/problems/add-two-numbers/
    /// 
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    /// 
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// </summary>
    public class AddTwoNumbers
    {

        /// <summary>
        /// Used to create a linked list based on an integer array
        /// </summary>
        /// <param name="arr">arr array of integers to convert to set of ListNodes</param>
        /// <returns> Linked List head based on input array </returns>
        public static ListNode arrToListNode(int[] arr)
        {

            ListNode ln = arr.Length > 1 ? new ListNode(arr[0]) : null;
            ListNode head = ln;

            for(int i = 1; i < arr.Length; i++)
            {
                ln.next = new ListNode(arr[i]);
                ln = ln.next;
            }

            return head;
        }

        /// <summary>
        /// Convert linked list to an array
        /// </summary>
        /// <param name="head"> head of the linked list </param>
        /// <returns> array based on the input linked list </returns>
        public static int[] listNodeToArr(ListNode head)
        {   
            // Array that will store each listnode's value
            int[] arr = new int[listNodeLength(head)];
            int i = 0; // Used to keep track of current index in array

            while(head != null) // If head is null, we've reached tail
            {
                // Set current array index to head.val
                arr[i++] = head.val;
                head = head.next; // move to next listnode
            }

            return arr;
        }

        /// <summary>
        /// gets the length of ListNode from head to tail
        /// </summary>
        /// <param name="head">current head of linked list</param>
        /// <returns>count of nodes in the linked list</returns>
        public static int listNodeLength(ListNode head)
        {
            if(head == null) return 0;

            return listNodeLength(head.next) + 1;
        }

        /// <summary>
        /// Solution Method
        /// </summary>
        /// <param name="l1"> 1st linked list </param>
        /// <param name="l2"> 2nd linked list </param>
        /// <returns>Summed Linked list based on the two linked lists</returns>
        public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            ListNode l2Next = null;
            ListNode l1Next = null;

            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null && l2 != null)
            {
                val = l2.val;
                l2Next = l2.next;
            }
            else if (l1 != null && l2 == null)
            {
                val = l1.val;
                l1Next = l1.next;
            }
            else
            {
                val = l1.val + l2.val;
                l1Next = l1.next;
                l2Next = l2.next;
            }

            if (val >= 10)
            {
                val -= 10;
                if (l1Next != null)
                {
                    l1Next.val += 1;
                }
                else if (l2Next != null)
                {
                    l2Next.val += 1;
                }
                else
                {
                    return new ListNode(val, new ListNode(1, null));
                }
            }

            return new ListNode(val, addTwoNumbers(l1Next, l2Next));

        }
    }
}
