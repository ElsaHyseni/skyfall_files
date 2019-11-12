using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    private AudioSource soundFX;

    [SerializeField]
    public AudioClip landClip, deathClip, iceBreakClip, gameOverClip, coinClip;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }    
    }
    public void LandSound (){
        soundFX.clip = landClip;
        soundFX.Play();
    }

    public void IceBreakSound()
    {
        soundFX.clip = iceBreakClip;
        soundFX.Play();
    }

    public void DeathSound()
    {
        soundFX.clip = deathClip;
        soundFX.Play();
    }

    public void GameOverSound()
    {
        soundFX.clip = gameOverClip;
        soundFX.Play();
    }

    public void CoinSound()
    {
        soundFX.clip = coinClip;
        soundFX.Play();
    }

 
}
