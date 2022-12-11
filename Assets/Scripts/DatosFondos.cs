using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DatosFondos : MonoBehaviour
{

    public static DatosFondos datosFondos;
    public String rutaArchivo;
    public int fondoSeleccionado;


    void Awake() {
        rutaArchivo=Application.persistentDataPath+"/fondos.dat";
        if(datosFondos==null)
        {
            datosFondos=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(datosFondos!=this)
            Destroy(gameObject);

        CargarFondo();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getFondo()
    {
        return fondoSeleccionado;
    }


    public void GuardarFondo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file= File.Create(rutaArchivo);
        
        DatosDeFondo datos= new DatosDeFondo();
        datos.fondoSeleccionado=fondoSeleccionado;
        bf.Serialize(file,datos);
        file.Close();
    }

    public void CargarFondo()
    {
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf =new BinaryFormatter();
            FileStream file=File.Open(rutaArchivo,FileMode.Open);

            DatosDeFondo datos=(DatosDeFondo) bf.Deserialize(file);

            fondoSeleccionado=datos.fondoSeleccionado;

            file.Close();      
        }
        else
        {
            fondoSeleccionado=0;
        }
    }


}

[Serializable]
class DatosDeFondo
{
    public int fondoSeleccionado;
}