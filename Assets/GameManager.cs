using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int nowcoin;
    [SerializeField]
    private int initial_coin;
    [SerializeField]
    private GameObject coinPrefab;
    [SerializeField]
    private Text nowcoinText;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initial_coin; i++)
        {
            StartInstantiatecoin();
        }
    }

    public void StartInstantiatecoin()
    {
        float x = Random.Range(-2, 2);
        float z = Random.Range(-1, -5);
        Instantiate(coinPrefab, new Vector3(x, 5, z), coinPrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        nowcoinText.text = "ƒRƒCƒ“:" + nowcoin;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (nowcoin != 0)
            {
                StartInstantiatecoin();
                nowcoin--;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        nowcoin++;
    }
}
