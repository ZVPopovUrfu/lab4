using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(Perceptron))]

public class ChangeColor : MonoBehaviour
{ 
    public Material False;
    public Material True;
    public int item1;
    public int item2;

    private void Start()
    {
        var perceptron = GetComponent<Perceptron>();
        perceptron.Train(8);

        GetComponent<MeshRenderer>().material = perceptron.CalcOutput(item1, item2) == 0 ? False : True;
    }
}
