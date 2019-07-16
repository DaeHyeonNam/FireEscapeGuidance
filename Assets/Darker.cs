using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using UnityEngine;

public class Darker : MonoBehaviour {
    public string tagName = "EachLight";
    GameObject[] EachLightObjects;     
    public System.IO.StreamReader reader = null;
    Light lt;
    public string line;
    bool[] a = { true, true, true , true,true, true,true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
        true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
        true, true, true, true, true, true, true, true, true, true, true, true, true, true, true , true,true, true,true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
        true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
        true, true, true, true, true, true, true, true, true, true, true, true,true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
        true, true, true, true, true, true, true, true, true, true, true, true, };
    Shader shader1;

    // Use this for initialization
    void Start () {
        lt = GetComponent<Light>();
        EachLightObjects = GameObject.FindGameObjectsWithTag(tagName).OrderBy( go => go.name ).ToArray();
        reader = new System.IO.StreamReader("Test.txt");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("p"))
        {
            int j = 0;
            while((line = reader.ReadLine())!= null)
            {
                if (line == "1")
                {
                    a[2*j] = true;
                    a[2 * j + 1] = false;
                }
                else if(line == "0")
                {
                    a[2*j] = false;
                    a[2 * j + 1] = true;
                }
                else
                {
                    a[2 * j] = true;
                    a[2 * j + 1] = true;
                }
                j++;
                print(a[2 * j]);
                print(a[2 * j+1]);
            }

            lt.intensity = 0.5F;
            
            int i = 0;
            /*foreach (GameObject EachObject in EachLightObjects)
            {
                EachLight eachLight = EachObject.GetComponent<EachLight>();
                eachLight.eachLight = a[i];
                if (a[i] == true)
                {
                    Renderer rend = EachObject.GetComponent<Renderer>();
                    shader1 = Shader.Find("UI/Default");
                    rend.material.shader = shader1;
                }
                i++;
            }*/
        }
    }
}
