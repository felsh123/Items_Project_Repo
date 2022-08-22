using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Distance : Weapons
{
    private int _attckDistance;
    public W_Distance(GameObject prefab, string name, int attckPower, int attckDistance = 10, float weight = 0, int price = 0) : base(prefab, name, attckPower, weight, price) //este es el constructor, el base hace referencia al constructor del Padre
    {                                                                                                                      //Poner los requeridos de primero, los opcionales de último.
        _attckDistance = attckDistance;
    }
}
