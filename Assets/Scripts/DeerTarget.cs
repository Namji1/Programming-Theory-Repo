using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed();
        GetGameManager();
        addedscore = 45;
    }

    // POLYMORPHISM
    protected override void SetSpeed()
    {
        defaultSpeed = 5.0f;
        base.SetSpeed();
    }
}
