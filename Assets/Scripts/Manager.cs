using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 using System;
public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;

    float forCounter;
    public GameObject button;
    bool hasUpgrade;

    public int cashPerClick=1;
    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUpgrade;
    protected float Timer;
    public int DelayAmount = 1;
    public void AddClicks()
    {
     
        GlobalMilk.milkCount +=cashPerClick;
      
        
    }

    public void AutoClickUpgrade()
    {
        if(!hasUpgrade && GlobalMilk.milkCount >= minimumClicksToUnlockUpgrade)
        {
            GlobalMilk.milkCount -= minimumClicksToUnlockUpgrade;
            hasUpgrade = true;
        }
    }

    private void Update()
    {
        Timer += Time.deltaTime;
         if (Timer >= DelayAmount){
            if(hasUpgrade)
            {
                Timer = 0f;
                forCounter= autoClicksPerSecond*2;
            
                GlobalMilk.milkCount += Math.Round(forCounter, 2);

                
            }
         }
    }
}
