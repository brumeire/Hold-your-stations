using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : ScriptableObject
{
    public enum EventType
    {
        Deplacement,
        Tir,
        FTL,
        Bouclier
    }

    public EventType eventType;

    public float eventTime;

    // Coordinates (Tir/Déplacement/FTL)
    public bool randomizeCoordinates;
    public Vector2 coordonnees;

    // Tir
    public StationCombat.Armes typeDeTir;

    // Energycost (Déplacement/FTL)
    public bool useGlobalValue;
    public bool mvtRandomizeEnergyCost;
    public float mvtEnergyCostMin = 2;
    public float mvtEnergyCostMax = 7;
    public float mvtCoutEnergieFixe = 3;

    // Bouclier
    public float direction; // 0 à 360


}
