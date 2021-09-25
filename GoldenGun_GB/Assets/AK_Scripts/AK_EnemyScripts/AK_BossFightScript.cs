using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AK_BossFightScript : MonoBehaviour
{
    public float maxTime;

    float shootMoment;
    float shootMoment2;

    public float timeLeft;


    public Transform playerShootingPoint;
    public Transform enemyShootingPoint;

    public Sprite victoryScreen;
    public Sprite defeatScreen;

    public Sprite playAgainScreenVictory;
    public Sprite playAgainScreenDefeat;

    bool canShoot;
    bool endScreen;

    public Sprite getReady;
    public Sprite shoot;

    SpriteRenderer spriteRend;

    public string levelScene;
    public string mainMenu;

    public GameObject playerBullet;
    public GameObject enemyBullet;



    private void Start()
    {
        //timesUpText.SetActive(false);
        
        timeLeft = maxTime;
        shootMoment = Random.Range(1, maxTime - 1);
        shootMoment2 = shootMoment - 0.5f;
        spriteRend = GetComponent<SpriteRenderer>();
        endScreen = false;
    }

    private void Update()
    {

        if (timeLeft > shootMoment)
        {
            timeLeft -= Time.deltaTime;
            spriteRend.sprite = getReady;
        }

        if (timeLeft > shootMoment2 && timeLeft < shootMoment)
        {
            spriteRend.sprite = shoot;
            if (Input.GetKeyDown(KeyCode.O) && canShoot)
            {
                Instantiate(playerBullet, playerShootingPoint.position, Quaternion.identity);
                Victory();
            }
        }
        if (timeLeft < shootMoment2)
        {
            spriteRend.sprite = null;
            if (Input.GetKeyDown(KeyCode.O) && canShoot)
            {
                Instantiate(enemyBullet, enemyShootingPoint.position, Quaternion.identity);
                Defeat();
            }
        }

        if (endScreen)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                SceneManager.LoadScene(levelScene);
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene(mainMenu);
            }
        } 
    }

    void Victory()
    {
        canShoot = false;
        StartCoroutine("VictoryCor");
    }

    void Defeat()
    {
        canShoot = false;
        StartCoroutine("DefeatCor");
    }

    IEnumerator DefeatCor() 
    {
        spriteRend.sprite = defeatScreen;

        yield return new WaitForSeconds(3f);

        spriteRend.sprite = playAgainScreenDefeat;

        endScreen = true;

        yield return null;
    }

    IEnumerator VictoryCor()
    {
        spriteRend.sprite = victoryScreen;

        yield return new WaitForSeconds(3f);

        spriteRend.sprite = playAgainScreenVictory;

        endScreen = true;

        yield return null;
    }
}
