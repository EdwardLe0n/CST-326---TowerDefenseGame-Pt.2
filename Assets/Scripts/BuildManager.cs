using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Set uo for singleton memthod

    public static BuildManager instance;

    // This awake runs befgor start
    // sets the static instance to this gameOnjectg
    private void Awake()
    {

        instance = this;

    }

    public GameObject standardTurrentPrefab;

    private void Start()
    {
        turretToBuild = standardTurrentPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;

    }

}
