using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 using System;
public class AddMilk : MonoBehaviour
{
    
    public int internalClick; 
   
    public void AddClicks()
    {
        internalClick=1;
        GlobalMilk.milkCount +=internalClick * GlobalUpgrades.upgrade6Count;
      
        
    }

    private void Update()
    {
        
         
    }
}
