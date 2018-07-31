using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTool : MonoBehaviour
{
    public List<Transform> insideObject = new List<Transform>(); // list that will be gameobject

    
    // Use this for initialization
    void Start()
    {

        Transform[] objeler= GameObject.FindObjectsOfType<Transform>(); // find the whole objects in hierarchy and add to this array

        foreach (Transform tr in objeler)
        {   
            //check all objects whether contained (other mean that inside this transform object) by this transform     
        
            if (transform.GetComponent<Collider>().bounds.Contains(tr.position) && tr.name!=transform.name)
            {
                //if inside this transform gameobject , object will be add list.
              insideObject.Add(tr);

            }

        }

    }


    private void OnTriggerEnter(Collider other)
    {
        //check whether Player(Fps Character) thigger to this transform gameobject

        if (other.gameObject.tag == "Player")
        {
            foreach (Transform tr in insideObject)
            {      
               

                tr.GetComponent<MeshRenderer>().enabled = true;
            }
        }   

    }

    private void OnTriggerExit(Collider other)
    {
        //check whether Player(Fps Character) thiggerExit to this transform gameobject

        if (other.gameObject.tag == "Player")
        {
            //if it was a trigger Exit, meshRendered component's active of gameobjects in added to list  will be false.

            foreach (Transform tr in insideObject)
            {
                tr.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
