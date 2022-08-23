using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrades : MonoBehaviour
{
    [SerializeField] public GameObject upgradeScope;
    [SerializeField] public GameObject upgradeFire;
    [SerializeField] public GameObject upgradeEngine;
    [SerializeField] public GameObject upgradeEngine1;
    [SerializeField] public GameObject upgradeEngine2;

    public void ChangeUpgrade(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log(upgradeScope.activeSelf);
                upgradeScope.SetActive(!upgradeScope.activeSelf); 
                break;
            case 1:
                upgradeFire.SetActive(!upgradeFire.activeSelf);
                break;
            case 2:
                upgradeEngine.SetActive(!upgradeEngine.activeSelf);
                break;
            case 3:
                upgradeEngine1.SetActive(!upgradeEngine1.activeSelf);
                break;
            case 4:
                upgradeEngine2.SetActive(!upgradeEngine2.activeSelf);
                break;
        }
    }
    public void ClearUpgrades()
    {
        upgradeScope.SetActive(false);
        upgradeFire.SetActive(false);
        upgradeEngine.SetActive(false);
        upgradeEngine1.SetActive(false);
        upgradeEngine2.SetActive(false);
    }
}
