using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Branchements

    public void BranchementStationInformations(bool state)
    {
        GameManager.instance.ChangeStationState(GameManager.StationList.Info, state);
    }

    public void BranchementStationCombat(bool state)
    {
        GameManager.instance.ChangeStationState(GameManager.StationList.Combat, state);
    }

    public void BranchementStationMoteur(bool state)
    {
        GameManager.instance.ChangeStationState(GameManager.StationList.Moteur, state);
    }

    public void BranchementStationCoordonnees(bool state)
    {
        GameManager.instance.ChangeStationState(GameManager.StationList.Coord, state);
    }



    // Coordonnees

    public void CoordonneeX(dynamic amount)
    {
        GameManager.instance.stationCoord.ChangeAimX(float.Parse(amount));
    }

    public void CoordonneeY(dynamic amount)
    {
        GameManager.instance.stationCoord.ChangeAimY(float.Parse(amount));
    }

    public void ModeCoordonnees(int mode)
    {
        GameManager.instance.stationCoord.ChangeAimMode((StationCoords.CoordModes) mode);
    }


    // Armes

    public void SwitchArme(int arme)
    {
        GameManager.instance.stationCombat.ChangeWeapon((StationCombat.Armes) arme);
    }

    public void RechargeArme(dynamic amount)
    {
        GameManager.instance.ChargeArme(float.Parse(amount));
    }

    public void LevierActivationCombat()
    {
        GameManager.instance.stationCombat.ActivationLevier();
    }


    // Bouclier
    public void BranchementBouclier(bool state)
    {
        GameManager.instance.stationCombat.ActivationBouclier(state);
    }

    public void RotationBouclier(dynamic value)
    {
        GameManager.instance.stationCombat.RotationBouclier(float.Parse(value));
    }


    // Moteur
    public void RechargeEnergie(dynamic amount)
    {
        GameManager.instance.ChargeEnergie(float.Parse(amount));
    }

    public void ActivationDeplacement()
    {
        GameManager.instance.stationMoteur.TriggerDeplacement();
    }

    public void RechargementHeat(dynamic amount)
    {
        GameManager.instance.DechargeHeat(float.Parse(amount));
    }

}
