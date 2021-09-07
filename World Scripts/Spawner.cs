using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;
    public static Spawner MySpawner
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Spawner>();
            }
            return instance;
        }

    }

    public Transform[] aseaSpawnPoints;
    public Transform[] efosSpawnPoints;
    public Transform[] newlowCaveSpawnPoints;
    public Transform[] diregardeCastleSpawnPoints;
    public Transform[] efosPassSpawnPoints;
    public Transform[] astadSpawnPoints;
    public Transform[] diregardeSpawnPoints;
    [Space]
    public Transform enemyHolder;
    [Space]
    public GameObject[] aseaEnemyPrefab;
    public GameObject[] efosEnemyPrefab;
    public GameObject[] newlowCaveEnemyPrefab;
    public GameObject[] diregardeCastleEnemyPrefab;
    public GameObject[] efosPassEnemyPrefab;
    public GameObject[] astadEnemyPrefab;
    public GameObject[] diregardeEnemyPrefab;
    private GameObject newEnemyClone;
    [Space]
    public float timeBetweenSpawn, spawnDelay;
    public int aseaEnemyCounter, aseaMaxEnemyCounter;
    public int efosEnemyCounter, efosMaxEnemyCounter;
    public int newlowCaveEnemyCounter, newlowCaveMaxEnemyCounter;
    public int diregardeCastleEnemyCounter, diregardeCastleMaxEnemyCounter;
    public int efosPassEnemyCounter, maxEfosPassEnemyCounter;
    public int astadEnemyCounter, astadMaxEnemyCounter;
    public int diregardeEnemyCounter, diregardeMaxEnemyCounter;

    void Start()
    {
        InvokeRepeating(nameof(AseaEnemySpawn), timeBetweenSpawn, spawnDelay);
        InvokeRepeating(nameof(EfosEnemySpawn), timeBetweenSpawn, spawnDelay);
        InvokeRepeating(nameof(NewlowCaveEnemySpawn), timeBetweenSpawn, spawnDelay);
        InvokeRepeating(nameof(DiregardeCastleEnemySpawn), timeBetweenSpawn, spawnDelay);
        InvokeRepeating(nameof(EfosPassEnemySpawn), timeBetweenSpawn, spawnDelay);
        InvokeRepeating(nameof(AstadEnemySpawn), timeBetweenSpawn, spawnDelay);


    }

    void AseaEnemySpawn()
    {
        if (aseaEnemyCounter == aseaMaxEnemyCounter)
            return;
        if (aseaEnemyCounter < aseaMaxEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, aseaEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, aseaSpawnPoints.Length);
            newEnemyClone = Instantiate(aseaEnemyPrefab[spawnEnemy], aseaSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            aseaEnemyCounter++;
        }
    }

    void EfosEnemySpawn()
    {
        if (efosEnemyCounter == efosMaxEnemyCounter)
            return;
        if (efosEnemyCounter < efosMaxEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, efosEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, efosSpawnPoints.Length);
            newEnemyClone = Instantiate(efosEnemyPrefab[spawnEnemy], efosSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            efosEnemyCounter++;
        }
    }

    void NewlowCaveEnemySpawn()
	{
        if (newlowCaveEnemyCounter == newlowCaveMaxEnemyCounter)
            return;
        if (newlowCaveEnemyCounter < newlowCaveMaxEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, newlowCaveEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, newlowCaveSpawnPoints.Length);
            newEnemyClone = Instantiate(newlowCaveEnemyPrefab[spawnEnemy], newlowCaveSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            newlowCaveEnemyCounter++;
        }
    }

    void DiregardeCastleEnemySpawn()
    {
        if (diregardeCastleEnemyCounter == diregardeCastleMaxEnemyCounter)
            return;
        if (diregardeCastleEnemyCounter < diregardeCastleMaxEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, diregardeCastleEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, diregardeCastleSpawnPoints.Length);
            newEnemyClone = Instantiate(diregardeCastleEnemyPrefab[spawnEnemy], diregardeCastleSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            diregardeCastleEnemyCounter++;
        }
    }
    void EfosPassEnemySpawn()
    {
        if (efosPassEnemyCounter == maxEfosPassEnemyCounter)
            return;
        if (efosPassEnemyCounter < maxEfosPassEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, efosPassEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, efosPassSpawnPoints.Length);
            newEnemyClone = Instantiate(efosPassEnemyPrefab[spawnEnemy], efosPassSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            efosPassEnemyCounter++;
        }
    }
    void AstadEnemySpawn()
    {
        if (astadEnemyCounter == astadMaxEnemyCounter)
            return;
        if (astadEnemyCounter < astadMaxEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, astadEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, astadSpawnPoints.Length);
            newEnemyClone = Instantiate(astadEnemyPrefab[spawnEnemy], astadSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            astadEnemyCounter++;
        }
    }
    void DiregardeEnemySpawn()
    {
        if (diregardeEnemyCounter == diregardeMaxEnemyCounter)
            return;
        if (diregardeEnemyCounter < diregardeMaxEnemyCounter)
        {
            var spawnEnemy = Random.Range(0, diregardeEnemyPrefab.Length);
            var spawnLocation = Random.Range(0, diregardeSpawnPoints.Length);
            newEnemyClone = Instantiate(diregardeEnemyPrefab[spawnEnemy], diregardeSpawnPoints[spawnLocation].position, Quaternion.identity) as GameObject;
            newEnemyClone.transform.parent = enemyHolder;
            diregardeEnemyCounter++;
        }
    }
}