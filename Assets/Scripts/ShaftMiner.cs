using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaftMiner : BaseMiner
{
    [SerializeField] private Transform shaftMiningLocation;
    [SerializeField] private Transform shaftDepositLocation;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            MoveMiner(shaftMiningLocation.position);
        }
    }
    protected override void CollectGold()
    {
        float collectTime = CollectCapacity / CollectPerSecond;
StartCoroutine(IECollect(CollectCapacity, collectTime));
    }
    protected override IEnumerator IECollect(int collectGold, float collectTime)
    {
        yield return new WaitForSeconds(collectTime);
        CurrentGold = collectGold;
        MoveMiner(shaftDepositLocation.position);
    }
}
