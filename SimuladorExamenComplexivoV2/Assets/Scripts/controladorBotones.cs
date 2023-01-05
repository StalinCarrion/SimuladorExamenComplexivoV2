using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorBotones : MonoBehaviour
{
    public Animator animacion;
    public GameObject a, b, c, d, e;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animacion.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);

        }
    }
}
