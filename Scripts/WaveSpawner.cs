using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public static int color;
    public Transform redWave;
    public Transform blueWave;
    public Transform greenWave;
    public Transform spawnLeftTop, spawnLeftMiddle,  spawnLeftBottom;
   
    private int numWaves = 0;
    private int lastWave = 0;
    private int waveBeforeLast = 0;
    private int timerLT = 9, timerLM = 6, timerLB = 1;
    public float betweenWaves = -1f;
    private float countDown = 1f;
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        color = 0;
        GameOver gameOver = GetComponent<GameOver>();
        
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            if (GameOver.score < 10)
            {
                SpawnWave();
                countDown = 1.3f;
            }
            else if (GameOver.score < 20)
            {
                SpawnWave();
                countDown = 1f;
            }
            else if (GameOver.score < 40)
            {
                SpawnWave();
                countDown = .5f;
            }
        }

    }

    void SpawnWave()
    {
        while (true)
        {
          
            int x = Random.Range(1, 4);
            if (x == 1 && !(lastWave == 2 && waveBeforeLast == 3) && !(lastWave == 3 && waveBeforeLast == 2))
            {
                
          
                Instantiate(redWave, spawnLeftTop.localPosition, Quaternion.identity);
                waveBeforeLast = lastWave;
                lastWave = 1;
                color = 1;
                break;
            }
            else if (x == 2 && !(lastWave == 1 && waveBeforeLast == 3) && !(lastWave == 3 && waveBeforeLast == 1))
            {
                
                Instantiate(blueWave, spawnLeftMiddle.localPosition, Quaternion.identity);
                waveBeforeLast = lastWave;
                lastWave = 2;
                color = 2;
     
                break;
            }
            else if (x == 3 && !(lastWave == 2 && waveBeforeLast == 1) && !(lastWave == 1 && waveBeforeLast == 2))
            {
              
                Instantiate(greenWave, spawnLeftBottom.localPosition, Quaternion.identity);
                waveBeforeLast = lastWave;
                lastWave = 3;
                color = 3;
              
                break;
            }
        }

        numWaves++;
    }
}



