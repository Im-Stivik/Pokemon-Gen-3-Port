using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EvoLvl", menuName = "Pokemon/Evolution/level_evolution", order = 0)]
public class EvoLvl : EvolutionMethod {
    [SerializeField] private short level;
}

