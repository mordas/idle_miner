using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaftMiner : BaseMiner
{
    [SerializeField] private Transform shaftMiningLocation;
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.M))
       {
        MoveMiner(shaftMiningLocation.position);   
       } 
    }
}
