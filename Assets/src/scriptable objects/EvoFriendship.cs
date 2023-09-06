using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "friendship evolution", menuName = "Pokemon/Evolution/friendship evolution", order = 0)]
public class EvoFriendship : EvolutionMethod 
{
    [SerializeField] private short friendship;
}
