using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalUpgrades: MonoBehaviour
{
    public static int upgrade1Count=0;
    public static int upgrade2Count=0;
    public static int upgrade3Count=0;
    public static int upgrade4Count=0;
    public static int upgrade5Count=0;
    public static int upgrade6Count=1;
    public GameObject upgrade1Display;
    public GameObject upgrade2Display;
    public GameObject upgrade3Display;
    public GameObject upgrade4Display;
    public GameObject upgrade5Display;
    public GameObject upgrade6Display;
    public GameObject upgrade1;
    public GameObject upgrade2;
    public GameObject upgrade3;
    public GameObject upgrade4;
    public GameObject upgrade5;
    public GameObject upgrade6;
    public static double Internalcost1=10;
    public static double Internalcost2=200;
    public static double Internalcost3=500;
    public static double Internalcost4=1250;
    public static double Internalcost5=5000;
    public static double Internalcost6=1;
    void Update()
    {
        upgrade1Display.GetComponent<Text>().text = "buy- "+Internalcost1.ToString("F2")+"$";
        upgrade2Display.GetComponent<Text>().text = "buy- "+Internalcost2.ToString("F2")+"$";
        upgrade3Display.GetComponent<Text>().text = "buy- "+Internalcost3.ToString("F2")+"$";
        upgrade4Display.GetComponent<Text>().text = "buy- "+Internalcost4.ToString("F2")+"$";
        upgrade5Display.GetComponent<Text>().text = "buy- "+Internalcost5.ToString("F2")+"$";
        upgrade6Display.GetComponent<Text>().text = "buy- "+Internalcost6.ToString("F2")+"$";
        upgrade1.GetComponent<Text>().text = "Have: "+upgrade1Count;
        upgrade2.GetComponent<Text>().text = "Have: "+upgrade2Count;
        upgrade3.GetComponent<Text>().text = "Have: "+upgrade3Count;
        upgrade4.GetComponent<Text>().text = "Have: "+upgrade4Count;
        upgrade5.GetComponent<Text>().text = "Have: "+upgrade5Count;
        upgrade6.GetComponent<Text>().text = "Have: "+upgrade6Count;
    }
}
