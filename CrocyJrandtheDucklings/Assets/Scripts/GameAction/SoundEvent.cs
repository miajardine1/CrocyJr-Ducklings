using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEvent : MonoBehaviour
{
   public AudioSource audioData;

   public void OnCollisionEnter()
   {
      audioData = GetComponent<AudioSource>();
      audioData.Play(0);
   }
   
   //https://docs.unity3d.com/ScriptReference/AudioSource.Play.html
}
