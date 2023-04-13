using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        defaultSpeed = 3.5f;
        speed = defaultSpeed;
        GetGameManager();
        addedscore = 65;
    }
}
