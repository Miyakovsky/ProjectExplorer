using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ProjectExplorer
{
    public class ProjectExplorer : EditorWindow
    {
        private const string WINDOW_MENU_NAME = "Tools/ProjectExplorer";
        private const string WINDOW_NAME = "ProjectExplorer";

        [MenuItem(WINDOW_MENU_NAME)]
        static void WindowOpen()
        {
            ProjectExplorer window = GetWindow<ProjectExplorer>(WINDOW_NAME);
            window.Show();
        }

        void OnGUI()
        {
            EditorGUILayout.LabelField("Example Label");
        }





    }
}