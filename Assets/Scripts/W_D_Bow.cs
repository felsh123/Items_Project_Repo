using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_D_Bow : W_Distance
{
    public W_D_Bow() : base(Resources.Load("DistanceWeapons/Bow") as GameObject, "Arco Simple", 3, 8, 120f, 5000)
    {

    }
}
