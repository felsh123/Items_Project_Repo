using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : Items
{
    private int _attckPower;
    public Weapons(GameObject prefab, string name, int attckPower, float weight = 0, int price = 0) : base(prefab, name, weight, price) //este es el constructor, el base hace referencia al constructor del Padre
    {                                                                                                                      //Poner los requeridos de primero, los opcionales de último.
        _attckPower = attckPower;

    }
}
