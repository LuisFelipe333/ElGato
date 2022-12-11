using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public int fondo;
    public GameObject cameraToChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressChange(){
        DatosFondos.datosFondos.fondoSeleccionado=fondo;
        DatosFondos.datosFondos.GuardarFondo();
        cameraToChange.GetComponent<ChangeBackGround>().changeColor();
    }
}
