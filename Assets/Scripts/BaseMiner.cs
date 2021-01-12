using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BaseMiner : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private int inititalCollectCapacity = 200;
    [SerializeField] private float goldCollectPerSecond = 50.0f;

    public int CurrentGold { get; set; }
    public int CollectCapacity { get; set; }
    public float CollectPerSecond { get; set; }
    public bool IsTimeToCollect { get; set; }
    void Awake()
    {
        _animator = GetComponent<Animator>();
        IsTimeToCollect = true;
        CurrentGold = 0;
        CollectCapacity = inititalCollectCapacity;
        CollectPerSecond = goldCollectPerSecond;
    }
    public virtual void MoveMiner(Vector3 newPosition)
    {
        transform.DOMove(newPosition, 10 / moveSpeed).OnComplete((() =>
        {
            if (IsTimeToCollect)
            {
                CollectGold();
            }
            else
            {
                DepositGold();
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
    protected virtual void DepositGold()
    {
    }
    public void ChangeGoal()
    {
        IsTimeToCollect = !IsTimeToCollect;
    }
    public void RotateMiner(int direction)
    {
        if (direction == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    protected Animator _animator;
}
