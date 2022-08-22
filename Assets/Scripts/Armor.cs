using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Items
{
    private int _defPower;
    public Armor(GameObject prefab, string name, int defPower = 5, float weight = 0, int price = 0) : base(prefab, name, weight, price) //este es el constructor, el base hace referencia al constructor del Padre
    {                                                                                                                      //Poner los requeridos de primero, los opcionales de último.
        _defPower = defPower;

    }
}
