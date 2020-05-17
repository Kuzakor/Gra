using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Postac : MonoBehaviour
{
    public int Zdrowie = 100;
    public int Doswiatczenie = 0;
    public int Poziom = 1;
    public int Siła = 1;
    List<object> Ekwipunek = new List<object>();

    // Start is called before the first frame update
    void Start()
    {
        Ekwipunek.Add("cep");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.back);
        }
        if (Zdrowie <= 0)
        {
            smierc();
        }
        if (Doswiatczenie >= 10)
        {
            Poziom = Poziom + 1;
            Zdrowie = Zdrowie + 25;
            Siła = Siła + 1;
        }
        
       

    }

    public void smierc()
    {
        Zdrowie = 100;

        Poziom = 1;
    }
}
