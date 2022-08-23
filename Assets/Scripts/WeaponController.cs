using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
    public GameObject colt;
    public GameObject maroszka;
    public GameObject MP41;
    public GameObject coltButton;
    public GameObject maroszkaButton;
    public GameObject MP41Button;


    // Start is called before the first frame update
    void Start()
    {
        colt.SetActive(false);
        maroszka.SetActive(false);
        MP41.SetActive(false);
        coltButton.SetActive(false);
        maroszkaButton.SetActive(false);
        MP41Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceneToColt()
    {
        colt.SetActive(true);
        maroszka.SetActive(false);
        MP41.SetActive(false);
        coltButton.SetActive(true);
        maroszkaButton.SetActive(false);
        MP41Button.SetActive(false);
    }
    public void ChangeSceneToMaroszka()
    {
        colt.SetActive(false);
        maroszka.SetActive(true);
        MP41.SetActive(false);
        coltButton.SetActive(false);
        maroszkaButton.SetActive(true);
        MP41Button.SetActive(false);
    }
    public void ChangeSceneToMP41()
    {
        colt.SetActive(false);
        maroszka.SetActive(false);
        MP41.SetActive(true);
        coltButton.SetActive(false);
        maroszkaButton.SetActive(false);
        MP41Button.SetActive(true);
    }


}
