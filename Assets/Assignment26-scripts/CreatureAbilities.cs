using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
   
    public class Creature : MonoBehaviour
    {
    
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

   
    public interface IRunnable
    {
        void Run();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public interface ISwimmable
    {
        void Swim();
    }

 
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }

        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }

        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
    }

 
    public class Duck : Creature, IRunnable, ISwimmable
    {
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
    }
}