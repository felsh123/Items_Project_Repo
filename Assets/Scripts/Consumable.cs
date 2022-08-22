using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Items
{
    private int _nStacks;
    public Consumable(GameObject prefab, string name, int nStacks = 1, float weight=0, int price=0) : base (prefab, name, weight, price) //este es el constructor, el base hace referencia al constructor del Padre
    {                                                                                                                      //Poner los requeridos de primero, los opcionales de último.
        _nStacks = nStacks;
    
    }
}
