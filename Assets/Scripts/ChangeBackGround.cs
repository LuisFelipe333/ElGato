using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackGround : MonoBehaviour
{
    // Start is called before the first frame update
    byte[,]colors=new byte[,]{
        {229, 158, 194},
        {209, 143, 231},
        {143, 214, 231}
    };
    byte r;
    byte g;
    byte b;


    void Start()
    {
        changeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {
        r=colors[DatosFondos.datosFondos.getFondo(),0];
        g=colors[DatosFondos.datosFondos.getFondo(),1];
        b=colors[DatosFondos.datosFondos.getFondo(),2];
        gameObject.GetComponent<Camera>().backgroundColor=new Color32(r,g,b,255);
        print(r+" "+g+" "+b);
    }
}
