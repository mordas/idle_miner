using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BaseMiner : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private int inititalCollectCapacity = 200;
    private float goldCollectPerSecond = 50.0f;

    public int CurrentGold { get; set; }
    public int CollectCapacity { get; set; }
    public float CollectPerSecond { get; set; }
    public bool IsTimeToCollect { get; set; }
    void Awake()
    {
        IsTimeToCollect = true;
        CurrentGold = 0;
        CollectCapacity = inititalCollectCapacity;
        CollectPerSecond = goldCollectPerSecond;
    }
    public void MoveMiner(Vector3 newPosition)
    {
        transform.DOMove(newPosition, 10 / moveSpeed).OnComplete((() =>
        {
            if (IsTimeToCollect)
            {
                CollectGold();
            }


        })).Play();
    }

    protected virtual void CollectGold()
    {

    }
    protected virtual IEnumerator IECollect(int collectGold, float collectTime)
    {
        yield return null;

    }
}
