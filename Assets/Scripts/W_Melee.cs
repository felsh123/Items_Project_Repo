using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Melee : Weapons
{
    private bool _oneHand;
    public W_Melee(GameObject prefab, string name, int attckPower, bool oneHand, float weight = 0, int price = 0) : base(prefab, name, attckPower, weight, price) //este es el constructor, el base hace referencia al constructor del Padre
    {                                                                                                                      //Poner los requeridos de primero, los opcionales de último.
        _oneHand = oneHand;
    }
}
