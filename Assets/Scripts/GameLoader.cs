using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public float savedMilk;
    public int savedCows;
    public int savedMen;
    public int savedCartons;
    public int savedTrucks;
    public int savedDads;
    public int savedCursor;
    public float savedMilkCost;
    public float savedCowsCost;
    public float savedMenCost;
    public float savedCartonsCost;
    public float savedTrucksCost;
    public float savedDadsCost;
    public float savedCursorCost;

    // Start is called before the first frame update
    void Start()
    {
        if(MainMenuOpt.isLoading==true){

            savedMilk = PlayerPrefs.GetFloat("SavedMilk");
            GlobalMilk.milkCount = savedMilk;

            savedCows = PlayerPrefs.GetInt("SavedCows");
            GlobalUpgrades.upgrade1Count = savedCows;
            
            savedMen = PlayerPrefs.GetInt("SavedMen");
            GlobalUpgrades.upgrade2Count = savedMen;

            savedCartons = PlayerPrefs.GetInt("SavedCartons");
            GlobalUpgrades.upgrade3Count = savedCartons;

            savedTrucks = PlayerPrefs.GetInt("SavedTrucks");
            GlobalUpgrades.upgrade4Count = savedTrucks;

            savedDads = PlayerPrefs.GetInt("SavedDads");
            GlobalUpgrades.upgrade5Count = savedDads;

            savedCursor = PlayerPrefs.GetInt("SavedCursor");
            GlobalUpgrades.upgrade6Count = savedCursor;

        
            savedCowsCost = PlayerPrefs.GetFloat("SavedCowsCost");
            GlobalUpgrades.Internalcost1 = savedCowsCost;
            
            savedMenCost = PlayerPrefs.GetFloat("SavedMenCost");
            GlobalUpgrades.Internalcost2 = savedMenCost;

            savedCartonsCost = PlayerPrefs.GetFloat("SavedCartonsCost");
            GlobalUpgrades.Internalcost3 = savedCartonsCost;

            savedTrucksCost = PlayerPrefs.GetFloat("SavedTrucksCost");
            GlobalUpgrades.Internalcost4 = savedTrucksCost;

            savedDadsCost = PlayerPrefs.GetFloat("SavedDadsCost");
            GlobalUpgrades.Internalcost5 = savedDadsCost;

            savedCursorCost = PlayerPrefs.GetFloat("SavedCursorCost");
            GlobalUpgrades.Internalcost6 = savedCursorCost;

        }
    }

    
}
