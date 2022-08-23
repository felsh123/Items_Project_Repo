using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_D_Spear : W_Distance
{
    public W_D_Spear() : base(Resources.Load("DistanceWeapons/Spear") as GameObject, "Lanza Simple",4, 6, 120f, 4700)
    {

    }
}
