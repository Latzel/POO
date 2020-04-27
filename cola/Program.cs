using System;
using System.Collections.Generic;

public class cola<T>
{

   readonly int m_Size; 

   int m_StackPointer = 0;

   public T[] m_Items;

   public cola():this(10)

   {}

   public cola(int size)
   {

      m_Size = size;

      m_Items = new T[m_Size];

   }

   public void Push(T item)
   {

      if(m_StackPointer >= m_Size) 
         {
             Console.WriteLine("Error StackOverFlow");
         }
    else
    {

      m_Items[m_StackPointer] = item;

      m_StackPointer++;
    }

   }

   public T Pop()
   {

      m_StackPointer--;

      if(m_StackPointer > 0)

      {

        T item = m_Items[0];
        for (int i=1; i< m_StackPointer; i++){

            m_Items[i-1]=m_Items[i];
        }
        m_StackPointer--;
        return item;

      }

      else

      {

         m_StackPointer = 0;

         throw new InvalidOperationException("Cannot pop an empty stack");

      }

   }

}

class Program
{
    static void Main(){
        cola<string> pila = new cola<string>();
        pila.Push("1");
        pila.Push("2");
        pila.Push("3");
        pila.Push("4");
        pila.Push("5");
        

        foreach(var item in pila.m_Items)
            Console.WriteLine(item);

        Console.WriteLine(pila.Pop());

         
         foreach(var item in pila.m_Items)
            Console.WriteLine(item);

    }
}