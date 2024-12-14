using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class Assignment27Script : MonoBehaviour
    {
        void Start()
        {
    
            int a = 9; 
            int b = 6; 

            Debug.Log($"Value of a before Call By Value: {a}");
            CallByValue(a); 
            Debug.Log($"Value of a after Call By Value: {a}");

            Debug.Log($"value of b before Call By Reference: {b}");
            CallByReference(ref b); 
            Debug.Log($"Value of b after Call By Reference: {b}");

            int c; 
            CallByOut(out c); 
            Debug.Log($"Value of c after Call By Out: {c}");
        }

       
        void CallByValue(int number)
        {
            number += 10; 
            Debug.Log($"Value inside CallByValue: {number}");
        }

     
        void CallByReference(ref int number)
        {
            number += 10; 
            Debug.Log($"Value inside CallByReference: {number}");
        }

      
        void CallByOut(out int number)
        {
            number = 20; 
            Debug.Log($"Value inside CallByOut: {number}");
        }
    }
}