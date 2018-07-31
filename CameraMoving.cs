
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraMoving : MonoBehaviour
{

    public float stopDist;
    public float movingSpeed;
    public GameObject target;
    public Vector3 distance;
    public float distanceMagnitude;
    public Text cameraText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = target.transform.position - transform.position; // uzaklıgı vector olarak alıyorum
        distanceMagnitude = distance.magnitude; // uzaklıgı birime donusturuyorun

        if (distanceMagnitude > stopDist) // kendi belirledigim dist degerine kadar cisim hareket edıyor
        {
            transform.position += distance.normalized * movingSpeed * Time.deltaTime;
        }
        else if (distanceMagnitude <= stopDist)
        {
            cameraText.text = "Distance = " + stopDist; // eger cisim o dist degerine gelmisse uyari anlamında text yazdım.
        }
    }

}


