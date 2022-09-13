using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FolderCreationTool : EditorWindow
{
    //Will need to create a character limit
    public string firstName = null;
    public string lastName = null;
    
    public string projectCode = null;

    string shortenedName = null;
    string studentName = null;


    [MenuItem("Tools/Folder Creation Tool")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(FolderCreationTool));
    }

    void OnGUI()
    {
        EditorGUILayout.Space();
        GUILayout.Label("Profile Name", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        firstName = EditorGUILayout.TextField("Enter First Name Here", firstName);
        EditorGUILayout.Space();

        lastName = EditorGUILayout.TextField("Enter Last Initial Here", lastName);

        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

        GUILayout.Label("Project Code", EditorStyles.boldLabel);

        EditorGUILayout.Space();
        projectCode = EditorGUILayout.TextField("Enter Project Code", projectCode);
        EditorGUILayout.Space();

        if (GUILayout.Button("Create Files"))
        {
            Apply();
        }
    }

    void Apply()
    {
        studentName = firstName + lastName;
        shortenedName = firstName[0] + lastName;

        Directory.CreateDirectory(Application.dataPath + "/" + studentName + "_" + projectCode + "_Assets");

        string pathStart = Application.dataPath + "/" + studentName + "_" + projectCode + "_Assets";

        if (!Directory.Exists(pathStart + "/" + shortenedName + "_ArtContent"))
        {
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_CourseFiles");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_ArtContent");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_ArtContent" + "/" + shortenedName + "_2D_Assets");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_ArtContent" + "/" + shortenedName + "_2D_Anim");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_Audio");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_Physics");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_Prefab");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_Scenes");
            Directory.CreateDirectory(pathStart + "/" + shortenedName + "_Scripts");
        }

        AssetDatabase.Refresh();
    }
}
