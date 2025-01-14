﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// ------------------------------------------
// ボタンのUIです
//
// ボタンを押すと画像がキャプチャーされます．
//

[CustomEditor(typeof(ImageSynthesis))]
public class ImageSaver : Editor
{

    // Update is called once per frame

    void Update() {

        Debug.Log("ImageSaver Update ...");
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ImageSynthesis imageSynthesis = (ImageSynthesis)target;

        // Only display the "Save" button if playing
        if (EditorApplication.isPlaying && GUILayout.Button("Save Captures")) 
        {
            Vector2 gameViewSize = Handles.GetMainGameViewSize();
            imageSynthesis.Save(imageSynthesis.filename, width: (int)gameViewSize.x, height: (int)gameViewSize.y, imageSynthesis.filepath);
        }
    }
}
