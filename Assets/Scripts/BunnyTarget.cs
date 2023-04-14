using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed();
        GetGameManager();
        addedscore = 65;
    }

    // POLYMORPHISM
    protected override void SetSpeed()
    {
        defaultSpeed = 3.5f;
        base.SetSpeed();
    }
}
