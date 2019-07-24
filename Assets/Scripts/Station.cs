using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Station
{
    public bool activationState;

}

[System.Serializable]
public class StationInfos : Station
{

}

[System.Serializable]
public class StationCombat : Station
{
    public enum Armes
    {
        ArmeBleue = 1,
        ArmeRouge = 2,
        None = 0
    }

    public float coutTirRouge = 8;
    public float coutTirBleu = 6;

    public bool bouclieractif = false;
    public Armes arme = Armes.None;

    public float bouclierDirection;


    public void ActivationBouclier(bool state)
    {
        bouclieractif = state;
    }

    public void ChangeWeapon(Armes weapon)
    {
        arme = weapon;
    }

    public void ActivationLevier()
    {
        ///TODO : logique d'activation armes ou shield
    }

    public void RotationBouclier(float value)
    {
        bouclierDirection = value;
    }


}
[System.Serializable]
public class StationCoords : Station
{
    public enum CoordModes
    {
        Deplacement = 1,
        FTL = 2,
        Tir = 3,
        None = 0
    }

    public float aimX;
    public float aimY;
    public CoordModes coordMode = CoordModes.None;



    public void ChangeAimX(float value)
    {
        aimX = value;
    }

    public void ChangeAimY(float value)
    {
        aimY = value;
    }

    public void ChangeAimMode(CoordModes newMode)
    {
        coordMode = newMode;
    }

}
[System.Serializable]
public class StationMoteur : Station
{
    public void TriggerDeplacement()
    {
        ///TODO : Faire logique déplacement
    }
}

