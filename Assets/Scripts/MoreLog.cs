﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int i = 1;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i + "");
        i = i + 1;
    }
}
