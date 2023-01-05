using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;


public class JavascriptHook : MonoBehaviour
{   
    public string correo, emailList;
    private string libre = "PRÁCTICA EN MODO LIBRE";
    public GameObject verde, azul;
    public TextMeshProUGUI nombresAng, correoAng;

    // Start is called before the first frame update
    void Start()
    {
         //SetNombre("Alex Romero");
    }

    // Update is called once per frame
    void Update()
    {
        List<string> list = new List<string>();
        list = correo.Split('@').ToList();
        emailList = list.First();     
    }

    // Start is called before the first frame update
    public void SetCorreo(string str)
    {
        //correo = str;
        correoAng.text = str;

    }

    public void SetNombre(string str)
    {
        if (str == "" || str == null || str == "null")
        {
            nombresAng.text = libre;
            azul.SetActive(true);
            verde.SetActive(false);
        }
        else
        {
            nombresAng.text = str;
            if (nombresAng.text != "Práctica en modo libre")
            {
                verde.SetActive(true);
                azul.SetActive(false);
            }
            else
            {
                azul.SetActive(true);
                verde.SetActive(false);
            }
        }
    }

}
