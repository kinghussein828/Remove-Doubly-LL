/************************************************************/
/*File Info    : program that Remove a node  of Doubly LL by using Remove method                */
/*Version     : v1.0                                                                                 */
/*Date         : 12\11\2021                                                                      */
/*Author      : Hussein Mohamad ELnaggar                                             */
/************************************************************/
using System;
using System.Collections.Generic;

public class program
{
    // Main Method is called
    static public void Main()
    {
      
        LinkedList<String> list = new LinkedList<String>();
        //AddLast() method is used to add the elements to the newly created linked list
        list.AddLast("Hussein");
        list.AddLast("Mohamad");
        list.AddLast("Abd El_Azim");
        list.AddLast("Mohamad");
        list.AddLast("Moustafa");
        list.AddLast("Elnaggar");
       
        Console.WriteLine("My name is:");
        //Using foreach loop to display the elements of the newly created linked list
        foreach (string myName in list)
        {
            Console.WriteLine(myName);
        }
        Console.WriteLine("My name after using Remove(LinkedListNode) method are:");
        //using Remove(LinkedListNode) method to remove a node from the linked list
        list.Remove(list.First);
        foreach (string myName in list)
        {
            Console.WriteLine(myName);
        }
        Console.WriteLine("My name after using Remove(T) method are:");
        //using Remove(T) method to remove a node from the linked list
        list.Remove("Mohamad");
        foreach (string myNam in list)
        {
            Console.WriteLine(myNam);
        }
        Console.WriteLine("My name after using RemoveFirst() method are:");
        //using RemoveFirst() method to remove the first node from the linked list
        list.RemoveFirst();
        foreach (string Name in list)
        {
            Console.WriteLine(Name);
        }
        Console.WriteLine("My name after using RemoveLast() method are:");
        //using RemoveLast() method to remove the last node from the linked list
        list.RemoveLast();
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        //using Clear() method to remove all the nodes from the linked list
        list.Clear();
        Console.WriteLine("The count of my name after using Clear() method is: {0}",
        list.Count);
    }
}