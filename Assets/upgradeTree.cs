using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeTree : MonoBehaviour
{
    public GameObject upgradeMeny, player, playerInv;
    public int points;
    public Text showPoints;

    public void Awake()
    {
        player = GameObject.Find("player");
        playerInv = GameObject.Find("playerInventory");
    }

    public void Update()
    {
        points = playerInv.GetComponent<playerInventory>()._UpgradePoints;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quitmenu();
        }
        showPoints.text = points.ToString();
    }

    public void OnClickUpgrade()
    {
        player.GetComponent<player>()._inAction = !player.GetComponent<player>()._inAction;
        upgradeMeny.SetActive(!upgradeMeny.activeSelf);
    }

    public void quitmenu()
    {
        player.GetComponent<player>()._inAction = false;
        upgradeMeny.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
