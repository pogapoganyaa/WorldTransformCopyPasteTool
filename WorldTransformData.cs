using UnityEngine;

namespace PogapogaEditor.EditorMenuItem
{
    //[CreateAssetMenu(menuName = "Pogapoga/WorldTransformData")]
    public class WorldTransformData : ScriptableObject
    {
        public Vector3 worldPosition;
        public Quaternion worldRotation;
    }
}

