using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaft : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] private ShaftMiner minerPefab;
    [SerializeField] private Deposit depositPrefab;
    [Header("Locations")]
    [SerializeField] private Transform miningLocation;
    [SerializeField] private Transform depositLocation;
    [SerializeField] private Transform depositInstntiationPosition;
    public Transform MiningLocation => miningLocation; 
    public Transform DepositLocation => depositLocation;
    public Deposit CurrentDeposit { get; set; }
    private GameObject _minersContainer;
    
    void Start()
    {
        _minersContainer = new GameObject("Miners");
        CreateMiner();
        CreateDeposit();
    }
    private void CreateMiner()
    {
        ShaftMiner newMiner = Instantiate(minerPefab, depositLocation.position, Quaternion.identity);
        newMiner.CurrentShaft = this;
        newMiner.transform.SetParent(_minersContainer.transform);
        newMiner.MoveMiner(miningLocation.position);
    }
    private void CreateDeposit(){
        
       CurrentDeposit = Instantiate(depositPrefab, depositInstntiationPosition.position, Quaternion.identity);
       CurrentDeposit.transform.SetParent(depositInstntiationPosition);
    }
}
