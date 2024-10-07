using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameObjectToggler : MonoBehaviour
{
    [SerializeField] private List<GameObject> targets;

    private void Toggle()
    {
        foreach (var target in targets){
            target.SetActive(!target.activeSelf);
        }
    }
    
    [CustomEditor(typeof(GameObjectToggler))]
    public class GameObjectTogglerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            var toggler = (GameObjectToggler) target;
            if (GUILayout.Button("Toggle"))
            {
                toggler.Toggle();
            }
        }
    }
}
