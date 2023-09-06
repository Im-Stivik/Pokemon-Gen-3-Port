using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item evolution", menuName = "Pokemon/Evolution/item evolution", order = 0)]
public class EvoItem : EvolutionMethod{
    [SerializeField] private Item item;
}

