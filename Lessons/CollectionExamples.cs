using System.Collections;
using System.Collections.Generic;
using System;
namespace Lessons
{
    public class CollectionExamples
    {

        public void MyListExample()
        {
            List<Dinosaur> myDino = new List<Dinosaur>();
            myDino.Add(new TRex());
            myDino.Add(new TRex() { Travel = "Stomp" });
            myDino.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dino in myDino)
            {
                Console.WriteLine("These dinos travel by {0}", dino.Travel);
                Console.WriteLine(dino);
            }
        }

        public void MyArrayListExample()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add("World");
            myArrayList.Add(42);
            myArrayList.Add(84);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            //REMOVED TWO ITEMS
            myArrayList.Remove(42);
            myArrayList.RemoveAt(0);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            //ADDED TWO ITEMS
            myArrayList.Add("Other");
            myArrayList.Add("Stuff");
            //myArrayList.Sort();                 //RESEARCH THE SORT & HOW IT RELATES TO AN ARRAY LIST

            //OBJECT TYPE + VARIABLE TO WHICH ITS ASSIGNED (i.e., foreach is a shortcut of a forloop, but no increment is required 
            //b/c you give it a size and it does its own looping internally; not efficient; not sorted)
            foreach (Object item in myArrayList)
            {
                Console.WriteLine("Type = {0}", item);
            }
        }
    }
}