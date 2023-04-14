using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed();
        GetGameManager();
        addedscore = 30;
    }
    protected override void SetSpeed()
    {
        defaultSpeed = 4.0f;
        base.SetSpeed();
    }
}
