using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AK_BossFightScript : MonoBehaviour
{
    public float maxTime;

    public float shootingWindow;

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

    public AK_PlayerAnimations playerAnim;
    public AK_PlayerAnimations bossAnim;

    private void Start()
    {
        //timesUpText.SetActive(false);
        
        timeLeft = maxTime;
        shootMoment = Random.Range(1, maxTime - 2 );
        shootMoment2 = shootMoment - shootingWindow;
        spriteRend = GetComponent<SpriteRenderer>();
        canShoot = true;
        endScreen = false;
    }

    private void Update()
    {
        if(timeLeft > 0)
            timeLeft -= Time.deltaTime;

        if (timeLeft > shootMoment)
        {
            
            spriteRend.sprite = getReady;
            if (Input.GetButtonDown("Shoot") && canShoot)
            {
                Instantiate(enemyBullet, enemyShootingPoint.position, Quaternion.identity);
                bossAnim.ChangeAnimationState(bossAnim.PLAYER_SHOOTING);
                timeLeft = 0;
                Defeat();
            }
        }

        if (timeLeft > shootMoment2 && timeLeft < shootMoment && canShoot)
        {
            spriteRend.sprite = shoot;
            if (Input.GetButtonDown("Shoot") && canShoot)
            {
                Instantiate(playerBullet, playerShootingPoint.position, Quaternion.identity);
                playerAnim.ChangeAnimationState(playerAnim.PLAYER_SHOOTING);
                timeLeft = 0;
                Victory();
            }
        }
        if (timeLeft < shootMoment2 && canShoot)
        {
            spriteRend.sprite = null;
            Instantiate(enemyBullet, enemyShootingPoint.position, Quaternion.identity);
            bossAnim.ChangeAnimationState(bossAnim.PLAYER_SHOOTING);
            timeLeft = 0;
            Defeat();
        }

        if (endScreen)
        {
            if (Input.GetButtonDown("Jump"))
            {
                SceneManager.LoadScene(levelScene);
            }

            if (Input.GetButtonDown("Shoot"))
            {
                SceneManager.LoadScene(mainMenu);
            }
        } 
    }

    void Victory()
    {
        canShoot = false;
        StartCoroutine(VictoryCor());
    }

    void Defeat()
    {
        canShoot = false;
        StartCoroutine(DefeatCor());
    }

    IEnumerator DefeatCor() 
    {
        yield return new WaitForSeconds(0.35f);

        spriteRend.sprite = defeatScreen;

        yield return new WaitForSeconds(3f);

        spriteRend.sprite = playAgainScreenDefeat;

        endScreen = true;

        yield return null;
    }

    IEnumerator VictoryCor()
    {
        yield return new WaitForSeconds(0.35f);

        spriteRend.sprite = victoryScreen;

        yield return new WaitForSeconds(3f);

        spriteRend.sprite = playAgainScreenVictory;

        endScreen = true;

        yield return null;
    }
}
