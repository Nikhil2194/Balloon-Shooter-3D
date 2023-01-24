using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public float range = 100f;

    public Transform bulletSpawnPoint;
    public float bulletSpeed = 750;
    public GameObject bulletPrefab;
    // [SerializeField] ParticleSystem bulletShootEffect;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public int MAX_SCORE_TO_WIN = 7;

    float currentTime = 0f;
   public float startTime = 30f;
    public TextMeshProUGUI timeText;

    public GameObject wrongBallon_Text;
    [SerializeField]public AudioClip gunShoot,wrongShotSound,ScoreUpSound,GameOverSound,GameWinSound,Music;
    [SerializeField] GameObject TargetUIanim;


    private void Start()
    {
        currentTime = startTime;
        SoundManager.instance.PlaySound(Music);
        LeanTween.scale(TargetUIanim, new Vector3(1f, 1f, 1f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(TargetUIanim, new Vector3(0f, 3.15f, 0f), 1f).setDelay(3f).setEase(LeanTweenType.easeInOutCubic);
    }

    private void Update()
    {
        UpdateTimer();
        WinCondition();
    }

    public void FireBullet()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        bullet.transform.SetParent(gameObject.transform);
        SoundManager.instance.PlaySound(gunShoot);
    }



    public void ScoreUp()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
        SoundManager.instance.PlaySound(ScoreUpSound);
    }

    public void ScoreDown()
    {
        EnableWrongBallonText();
        score--;
        scoreText.text = "Score: " + score.ToString();
        EnableWrongBallonText();
         SoundManager.instance.PlaySound(wrongShotSound);
    }

    public void ScoreDown2()
    {
         EnableWrongBallonText();
        Debug.Log("Cat");
        score = score-2;
        scoreText.text = "Score: " + score.ToString();
        SoundManager.instance.PlaySound(wrongShotSound);
    }


    void UpdateTimer()
    {
        currentTime -= 1 * Time.deltaTime;
        //  float min = Mathf.FloorToInt(currentTime / 60);
       float sec = Mathf.FloorToInt(currentTime % 360);
        timeText.text = "Time Left : " + sec.ToString();
    }

    void WinCondition()
    {
        if (currentTime > 0)
        {
            if (score >= MAX_SCORE_TO_WIN)
            {
                SoundManager.instance.StopSound(Music);
                SoundManager.instance.PlaySound(GameWinSound);
                //LevelManager.Instance.LoadScene("GameWin");
                SceneManager.LoadScene("GameWin");
            }
        }
        else
        {
            if (score >= MAX_SCORE_TO_WIN)
            {
                SoundManager.instance.StopSound(Music);
                SoundManager.instance.PlaySound(GameOverSound);
                // Debug.Log("YOU WON AT LAST MOMENT!");
                //  LevelManager.Instance.LoadScene("GameWin");
                SceneManager.LoadScene("GameWin");
            }
            else
            {
                SoundManager.instance.StopSound(Music);
                SoundManager.instance.PlaySound(GameOverSound);
                // Debug.Log("TIMES UP! YOU LOSE! ");
                // Invoke("GameOver",10f);  //LevelManager.Instance.LoadScene("GameOver");
                SceneManager.LoadScene("GameOver");
            }
        }
    }


    public void EnableWrongBallonText()          //METHOD FOR TEXT APPEARING AFTER WRONG BALLOON SHOOT
    {
        wrongBallon_Text.SetActive(true);
        Invoke("DisableTextBallon", 2.6f);
    }
      void DisableTextBallon()
    {
        wrongBallon_Text.SetActive(false);
    }


}
