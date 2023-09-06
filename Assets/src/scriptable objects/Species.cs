 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MissingNo", menuName = "Pokemon/Species", order = 0)]
public class Species : ScriptableObject {

    [SerializeField]private ushort baseHP;
    [SerializeField] private ushort baseAttack;
    [SerializeField] private ushort baseDefence;
    [SerializeField] private ushort spAttack;
    [SerializeField] private ushort spDeffence;
    [SerializeField] private ushort speed;

    [SerializeField] private Type primaryType;
    [SerializeField] private Type seconderyType;

    [SerializeField] private ushort catchRate;
    [SerializeField] private ushort expYield;
    
    [SerializeField]private ushort evYield_HP;
    [SerializeField] private ushort evYield_Attack;
    [SerializeField] private ushort evYield_Defence;
    [SerializeField] private ushort evYield_spAttack;
    [SerializeField] private ushort evYield_spDeffence;
    [SerializeField] private ushort evYield_speed;

    [SerializeField] private Item itemCommon;
    [SerializeField] private Item itemRare;

    [SerializeField] private bool genderless;
    [SerializeField] private float genderRatio; //precet of female.
    
    [SerializeField] private ushort eggCycles;
    [SerializeField] private ushort friendship;

    [SerializeField] private GrouthRate grouthRate;
    [SerializeField] private EggGroup[] eggGroups;

    [SerializeField] private Ability[] abilities;
    [SerializeField] private ushort safariZoneFleeRate;
    [SerializeField] private BodyColor bodyColor;
    [SerializeField] private bool noFlip;
    
    [SerializeField] private EvolutionMethod[] evolutions;

    [SerializeField] private AudioClip cry;
}

