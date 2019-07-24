using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    // VARIABLES DE JEU
    public float energyCharge;
    public float heatCharge;
    public int lifePoints;
    public float weaponCharge;
    public float hazardCharge;

    public float weaponChargeMax = 10;
    public float energyChargeMax = 10;
    public float heatChargeMax = 10;

    public float coutEnergieTirRouge = 4;
    public float coutEnergieTirBleu = 3;
    public float coutEnergieBouclier = 4;

    public StationInfos stationInfo;
    public StationCoords stationCoord;
    public StationMoteur stationMoteur;
    public StationCombat stationCombat;
    
    public enum StationList
    {
        Info,
        Coord,
        Moteur,
        Combat
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        InitializeStations();
    }


    void InitializeStations()
    {
        stationInfo = new StationInfos();
        stationCombat = new StationCombat();
        stationCoord = new StationCoords();
        stationMoteur = new StationMoteur();
    }

    public void ChangeStationState(StationList station, bool state)
    {
        switch(station)
        {
            case StationList.Info:
                stationInfo.activationState = state;
                break;

            case StationList.Coord:
                stationCoord.activationState = state;
                break;

            case StationList.Moteur:
                stationMoteur.activationState = state;
                break;

            case StationList.Combat:
                stationCombat.activationState = state;
                break;
        }
    }

    public void ChargeArme(float amount)
    {
        weaponCharge = Mathf.Clamp(weaponCharge + amount, 0, weaponChargeMax);
        
    }

    public void ChargeEnergie(float amount)
    {
        energyCharge = Mathf.Clamp(energyCharge + amount, 0, energyChargeMax);
    }

    public void DechargeHeat(float amount)
    {
        heatCharge = Mathf.Clamp(heatCharge - amount, 0, heatChargeMax);
    }
}
