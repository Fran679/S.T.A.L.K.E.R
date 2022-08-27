using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dapper.Items
{
    public abstract class Hotbaritem : MonoBehaviour
    {
        [Header("Basic Info")]
        [SerializeField] private new string name = "New Hotbar Item Name";
        [SerializeField] private Sprite icon = null;

        public string Name => name;
        public abstract string ColouredName { get; }
        public Sprite Icon => icon;

        public abstract string GetInfoDisplayText();
    }
}
