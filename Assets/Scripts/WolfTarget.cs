using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed();
        GetGameManager();
        addedscore = 20;
    }
    protected override void SetSpeed()
    {
        defaultSpeed = 4.5f;
        base.SetSpeed();
    }
}
