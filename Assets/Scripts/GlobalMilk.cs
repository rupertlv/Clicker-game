using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalMilk : MonoBehaviour
{
    public static double milkCount;
    public GameObject MilkDisplay;
     public GameObject MilkDisplay2;
    public double InternalMilk;
    void Update()
    {
        InternalMilk=milkCount;
        MilkDisplay.GetComponent<Text>().text = InternalMilk.ToString("F2") + "$";
        MilkDisplay2.GetComponent<Text>().text = InternalMilk.ToString("F2") + "$";
    }
}
