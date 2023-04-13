using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        defaultSpeed = 5.0f;
        speed = defaultSpeed;
        GetGameManager();
        addedscore = 45;
    }

}
