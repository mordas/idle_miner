using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShaftUI : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI currentGoldTMP;
   private Shaft _shaft;
   void Start()
   {
   _shaft = GetComponent<Shaft>()    ;
   }
   void Update()
   {
   currentGoldTMP.text = _shaft.CurrentDeposit.CurrentGold.ToString();    
   }
}
