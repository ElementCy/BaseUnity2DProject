using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class SaveOnPlay
{
	static SaveOnPlay()
	{

		EditorApplication.playmodeStateChanged = () =>
		{

			if( EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying )
			{
				UnityEngine.SceneManagement.Scene scene = EditorSceneManager.GetActiveScene();
				Debug.Log( "Saving scene before entering Play mode: " + scene.name );
				
				EditorSceneManager.SaveScene(scene);
				EditorApplication.SaveAssets();
			}

		};

	}
}