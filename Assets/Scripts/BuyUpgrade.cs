using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUpgrade : MonoBehaviour
{
    public void BuyUpgrade1()
    {
        if(GlobalMilk.milkCount-GlobalUpgrades.Internalcost1<0){
            
        }else{
            GlobalMilk.milkCount -= GlobalUpgrades.Internalcost1;
            GlobalUpgrades.upgrade1Count+=1;
            GlobalUpgrades.Internalcost1=GlobalUpgrades.Internalcost1 * 1.5;
        }
    }
    public void BuyUpgrade2()
    {
         if(GlobalMilk.milkCount-GlobalUpgrades.Internalcost2<0){
            
        }else{
            GlobalMilk.milkCount -= GlobalUpgrades.Internalcost2;
            GlobalUpgrades.upgrade2Count+=1;
            GlobalUpgrades.Internalcost2=GlobalUpgrades.Internalcost2 * 1.55;
        }
    }
    public void BuyUpgrade3()
    {
         if(GlobalMilk.milkCount-GlobalUpgrades.Internalcost3<0){
            
        }else{
            GlobalMilk.milkCount -= GlobalUpgrades.Internalcost3;
            GlobalUpgrades.upgrade3Count+=1;
            GlobalUpgrades.Internalcost3=GlobalUpgrades.Internalcost3 * 1.7;
        }
    }
    public void BuyUpgrade4()
    {
        if(GlobalMilk.milkCount-GlobalUpgrades.Internalcost4<0){
            
        }else{
            GlobalMilk.milkCount -= GlobalUpgrades.Internalcost4;
            GlobalUpgrades.upgrade4Count+=1;
            GlobalUpgrades.Internalcost4=GlobalUpgrades.Internalcost4 * 2;
        }
    }
    public void BuyUpgrade5()
    {
     if(GlobalMilk.milkCount-GlobalUpgrades.Internalcost5<0){
            
        }else{
            GlobalMilk.milkCount -= GlobalUpgrades.Internalcost5;
            GlobalUpgrades.upgrade5Count+=1;
            GlobalUpgrades.Internalcost5=GlobalUpgrades.Internalcost5 * 3;
        }
    }
    public void BuyUpgrade6()
    {
    if(GlobalMilk.milkCount-GlobalUpgrades.Internalcost6<0){
            
        }else{
            GlobalMilk.milkCount -= GlobalUpgrades.Internalcost6;
            GlobalUpgrades.upgrade6Count+=1;
            GlobalUpgrades.Internalcost6=GlobalUpgrades.Internalcost6 * 1.6;
        }
    }
}
