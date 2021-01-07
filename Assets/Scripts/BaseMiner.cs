using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BaseMiner : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private int inititalCollectCompacity = 200;
    private float goldCollectPerSecond = 50.0f;

public void MoveMiner(Vector3 newPosition){
    transform.DOMove(newPosition, 10/moveSpeed).Play();
}
}
