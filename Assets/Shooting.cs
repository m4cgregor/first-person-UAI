using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPosition;

    public GameObject bulletPrefab;

    public float bulletForce;

    public Text killCountUI;

    public int killCount;


    public int TotalEnemys;
    public int TotalEnemysKilled;

    private void Start()
    {
        TotalEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }






    // Update is called once per frame

    void Update()

    {

        if (Input.GetMouseButtonDown(0))
        {



            



            GameObject bulletClone = Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);



            Rigidbody rb = bulletClone.GetComponent<Rigidbody>();



            rb.AddRelativeForce(Vector3.up * bulletForce, ForceMode.Impulse);



        }

        if(TotalEnemysKilled == TotalEnemys)
        {
            SceneManager.LoadScene(3);
        }


    }

    public void EnemyKilled()
    {
        killCount++;
        TotalEnemysKilled++;
        killCountUI.text = killCount.ToString();
    }




}
