﻿using UnityEngine;

namespace HexagonWar.ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewRangedUnit", menuName = "UnitData/New Ranged Unit")]
    public class RangedUnitLevelDataSO : UnitLevelDataSO
    {
        [Space(10)]
        [SerializeField] protected int _attackRadius;

        public override int HighestDangerousLevel { get; } = 0;

        public override int AttackRadius => _attackRadius;
        public override int Health { get; } = 2;
    }
}