using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

	public AudioMixer audioMixer;
	
	public  void SetVolume (float volume)
	{
		audioMixer.SetFloat("volume", volume);
	}
	
	public void Mute()
	{
		AudioListener.pause = !AudioListener.pause;
	}
	
	public void setFullScreen(bool isFullScreen)
	{
		Screen.fullScreen = isFullScreen;
	}
}
