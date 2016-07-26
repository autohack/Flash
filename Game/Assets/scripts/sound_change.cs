using UnityEngine;
using System.Collections;
 /// <summary>
 /// Sound_change.
 /// </summary>
 public class Sound_change : MonoBehaviour 
 {
     
     public AudioSource _AudioSource1;
     public AudioSource _AudioSource2;
     public AudioSource _AudioSource3;
 
    
     
     /// <summary>
     /// Raises the  event On click 
     /// </summary>
     public void Onclick() {
		_AudioSource1.Play();
		_AudioSource2.Stop();
        _AudioSource3.Stop();
	}
	
 
 }