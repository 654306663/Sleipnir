﻿using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Sleipnir.Editor
{
    namespace Collections.NodeEditor.Editor
    {
        public class GraphDrawer<T> : OdinValueDrawer<T> where T : IGraph
        {
            protected override void DrawPropertyLayout(GUIContent label)
            {
                if (GUILayout.Button("Open editor"))
                {
                    var window = (GraphEditor)EditorWindow.GetWindow(typeof(GraphEditor));
                    window.LoadGraph(ValueEntry.SmartValue);
                }

                CallNextDrawer(label);
            }
        }
    }
}