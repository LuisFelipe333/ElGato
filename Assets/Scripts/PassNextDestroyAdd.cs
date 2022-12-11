using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassNextDestroyAdd : MonoBehaviour
{
    public string scene;
    public GameObject ad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PassScene()
    {
        ad.GetComponent<BannerAd>().hideAd();
        SceneManager.LoadScene(scene);

    }
}