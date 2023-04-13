using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfTarget : Targets
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        defaultSpeed = 4.5f;
        speed = defaultSpeed;
        GetGameManager();
        addedscore = 20;
    }
}
