using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveGame : MonoBehaviour
{
    public double saveGameMilk;
    public GameObject saveButton;

    void Update()
    {
        saveGameMilk = GlobalMilk.milkCount;
        if(saveGameMilk>0){
            saveButton.GetComponent<Button>().interactable = true;
        }else{
            saveButton.GetComponent<Button>().interactable = false;
        }

    }

    public void SaveTheGame(){
        PlayerPrefs.SetFloat("SavedMilk",(float)GlobalMilk.milkCount);
        PlayerPrefs.SetInt("SavedCows",GlobalUpgrades.upgrade1Count);
        PlayerPrefs.SetInt("SavedMen",GlobalUpgrades.upgrade2Count);
        PlayerPrefs.SetInt("SavedCartons",GlobalUpgrades.upgrade3Count);
        PlayerPrefs.SetInt("SavedTrucks",GlobalUpgrades.upgrade4Count);
        PlayerPrefs.SetInt("SavedDads",GlobalUpgrades.upgrade5Count);
        PlayerPrefs.SetInt("SavedCursor",GlobalUpgrades.upgrade6Count);
        
        PlayerPrefs.SetFloat("SavedCowsCost",(float)GlobalUpgrades.Internalcost1);
        PlayerPrefs.SetFloat("SavedMenCost",(float)GlobalUpgrades.Internalcost2);
        PlayerPrefs.SetFloat("SavedCartonsCost",(float)GlobalUpgrades.Internalcost3);
        PlayerPrefs.SetFloat("SavedTrucksCost",(float)GlobalUpgrades.Internalcost4);
        PlayerPrefs.SetFloat("SavedDadsCost",(float)GlobalUpgrades.Internalcost5);
        PlayerPrefs.SetFloat("SavedCursorCost",(float)GlobalUpgrades.Internalcost6);

    }
}
