using UnityEngine;

namespace C_Script
{
    [CreateAssetMenu(menuName = "Data/TestData",fileName = "Data")]
    public class TestItem : ScriptableObject
    {
        [field:SerializeField]public int ID { get; set; }
    }
}
