using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementsScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Welcome to our game!");
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.W))
         {
            
         }
         if (Input.GetKey(KeyCode.D))
         {
            transform.Rotate(0, 1, 0);
         }
           if (Input.GetKey(KeyCode.A))
         {
            transform.Rotate(0, -1, 0);
         }
           
           
       
        //M de-activate and activate visibility of the object
         if (Input.GetKeyDown(KeyCode.M))

       {
            if (GetComponent<MeshRenderer>().enabled)
            {
               GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
       Debug.Log("My cube has touched" + col.gameObject.name );
    }
      void OnCollisionExit(Collision Collision)
    {
       Debug.Log("My cube has lost touched with " + Collision.gameObject.name);
    }
      void OnCollisionStay(Collision Collision)
    {  

    }
    
}      
    
