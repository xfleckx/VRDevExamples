using UnityEngine;
using System.Collections;

public class GrenadeLauncher : MonoBehaviour {

    public GameObject grenadePrefab;

    public void Launch()
    {
        Instantiate(grenadePrefab);
    }


    void OnGUI()
    {
        if (GUILayout.Button("Launch"))
        {
            Launch();
        }
    }
}
