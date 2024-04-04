using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {

        Debug.Log("Standard Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurrentPrefab);

    }

    public void PurchaseMissileLauncher()
    {

        Debug.Log("Missile Launcher Selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);

    }

}
