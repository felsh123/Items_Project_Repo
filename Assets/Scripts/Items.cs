using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : CustomGameObject
{
    protected float _weight;
    protected int _price;

    public Items(GameObject prefab, string name, float weight=0, int price=0) : base (prefab, name) //este es el constructor, el base hace referencia al constructor del Padre
    {
        _weight = weight;
        _price = price;
    
    }
    
    public int price
    {
        get { return _price; }
    }
    
    
    
}
