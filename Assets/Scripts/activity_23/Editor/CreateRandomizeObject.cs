using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Public.Extensions;
using NUnit.Framework.Internal;
using UnityEngine.TextCore.Text;

[CustomEditor(typeof(GeometryList))]
public class CreateRandomizeObject : Editor
{
    private string objectName = "NovoGameObject";

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GeometryList myTarget = (GeometryList)target;

        GUILayout.Label("Criar Game Object", EditorStyles.boldLabel);
        objectName = EditorGUILayout.TextField("Nome do objeto", objectName);

        if (GUILayout.Button("Criar GameObject"))
        {
            CreateGameObject();
        }

        if (GUILayout.Button("Criar Formula Randomizada"))
        {
            var random3DObject = myTarget.list.GetRandom();
            CreateGameObject(random3DObject);
        }
        
        if (GUILayout.Button("Adicionar Inimigo"))
        {
            List<GameObject> filteredCharacterList = myTarget.charactersList.FilterByTag("Enemy");

            foreach ( GameObject character in filteredCharacterList)
            {
                CreateGameObject(character);
            }
        }
    }

    private void CreateGameObject(GameObject random3DObject = null)
    {
        GameObject newObject;

        if (random3DObject != null)
        {
            newObject = Instantiate(random3DObject);
            newObject.name = $"{objectName}::{newObject.name}";
        }
        else
        {
            newObject = new GameObject(objectName);
        }

        newObject.transform.position = Vector3.zero;

        Selection.activeObject = null;
        Selection.activeObject = newObject;
    }
}
