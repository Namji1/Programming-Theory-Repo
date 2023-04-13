using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        defaultSpeed = 4.0f;
        speed = defaultSpeed;
        GetGameManager();
        addedscore = 30;
    }

}
