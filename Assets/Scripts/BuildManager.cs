using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Set uo for singleton memthod

    public static BuildManager instance;

    // This awake runs befgor start
    // sets the static instance to this gameObject
    private void Awake()
    {

        instance = this;

    }

    public GameObject standardTurrentPrefab;
    public GameObject missileLauncherPrefab;

    private TurretBlueprint turretToBuild;

    // Basically a small function that returns if turrettoBuild is null or not
    public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn(Node someNode)
    {
        // Build a turret
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, someNode.GetBuildPosition(), Quaternion.identity);
        someNode.turret = turret;

    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
