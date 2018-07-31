using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDirection : MonoBehaviour
{

    //script herhangi bir objemizin içinde
  
    public Transform obj; //  yön kontrolü yapacagımız obje
    public Text directionText; //ters yöne kayma anında yazılacak yazı

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hareketKontrol();  // kodun çalışmasını test için hareket kontrolu sağladım

        //Debug.Log(crossValue());


        // bu degerler yani -0.5 ile -1 arası açı değerleri , yyaklaşık 120 dereceye geliyor
        // target objenin forward noktasıyla  bizim objenin forward noktası arasındaki açı değeri 120 olunca ters yön uyarisi veriyor. degerler değiştirilebilir.
        if (crossValue()<=-0.5 && crossValue() >= -1)
        {
            directionText.text = "Ters Yöndesin"; // ters yön durumunda texte yazıyor
        }else
        {
            directionText.text = "";
        }


        // bu kısımda açı olarak yaptım dotProduct yerine bu şekildede yapabildim

        /*
        float angle = Vector3.Angle(obj.forward, transform.forward);
        Debug.Log(angle);
        if (angle > 120)
        {
            directionText.text = "Ters Yöndesin";
        }
        else
        {
            directionText.text = "";
        }
           */

    }

    float crossValue()
    {   
        // iki vectorude dot Product ile çarptım çıkan değer 1 , -1 veye 0 aralıklarında .
        return Vector3.Dot(transform.forward, obj.transform.forward);

    }

    void hareketKontrol()
    {
      //hareket kontrolu
        transform.Translate(0, 0, Input.GetAxis("Vertical") / 4);
        transform.Rotate(0, Input.GetAxis("Horizontal") * 2, 0);

    }

}
