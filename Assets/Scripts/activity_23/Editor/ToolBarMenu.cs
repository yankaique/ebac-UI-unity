using UnityEngine;
using UnityEditor;

public class ToolBarMenu : EditorWindow
{
    [MenuItem("Custom Tools/Create GameObject Button")]
    public static void ShowWindow()
    {
        GameObject newObject = new GameObject("novo objeto");
        newObject.transform.position = Vector3.zero;
        Selection.activeObject = newObject;
    }
}