using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMilking : MonoBehaviour
{
    public bool gettingMilk = false;

    public double basemilk1;
    public double basemilk2;
    public double basemilk3;
    public double basemilk4;
    public double basemilk5;
    // Update is called once per frame
    void Update()
    {
        basemilk1=0.5;
        basemilk2=2;
        basemilk3=5;
        basemilk4=12;
        basemilk5=20;
        if(gettingMilk==false){
            gettingMilk = true;
            StartCoroutine(GetTheMilk());
        }
    }
    IEnumerator GetTheMilk(){
        GlobalMilk.milkCount += basemilk1 * GlobalUpgrades.upgrade1Count;
        GlobalMilk.milkCount += basemilk2 * GlobalUpgrades.upgrade2Count;
        GlobalMilk.milkCount += basemilk3 * GlobalUpgrades.upgrade3Count;
        GlobalMilk.milkCount += basemilk4 * GlobalUpgrades.upgrade4Count;
        GlobalMilk.milkCount += basemilk5 * GlobalUpgrades.upgrade5Count;
        yield return new WaitForSeconds(1);
        gettingMilk = false;
    }

}
