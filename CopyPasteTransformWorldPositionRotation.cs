#if UNITY_EDITOR
using UnityEditor;

namespace PogapogaEditor.EditorMenuItem
{
    public class CopyPasteTransformWorldPositionRotation : Editor
    {
        private static string guid = "ea92c9918054b644e8c4c7494a67f116"; // 保存先のGUID

        [MenuItem("CONTEXT/Transform/Copy World Position And World Rotation")]
        static void CopyWorldPositionAndRotation()
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            WorldTransformData worldTransformData =
                AssetDatabase.LoadAssetAtPath<WorldTransformData>(assetPath);
            worldTransformData.worldPosition = Selection.activeTransform.position;
            worldTransformData.worldRotation = Selection.activeTransform.rotation;
        }

        [MenuItem("CONTEXT/Transform/Paste World Position And World Rotation")]
        static void PasteWorldPositionAndRotation()
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            WorldTransformData worldTransformData =
               AssetDatabase.LoadAssetAtPath<WorldTransformData>(assetPath);

            Undo.RecordObject(Selection.activeTransform, "Paste World Position And World Rotation");
            Selection.activeTransform.position = worldTransformData.worldPosition;
            Selection.activeTransform.rotation = worldTransformData.worldRotation;
        }
    }
}
#endif