using UnityEngine;
using System.Collections;

public class SoundHelper : MonoBehaviour {

	public static SoundHelper Instance;

	public AudioClip _startSound;
	public AudioClip _gameSound;
	public AudioClip _holeInSound;
	public AudioClip _mainInUrmaVaRog;
	public AudioClip _shiniNuOTransmis;
	public AudioClip _dvijokMashina;


	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
		DontDestroyOnLoad (Instance.gameObject);
	}
	
	public void startSound()
	{
		MakeSound(_startSound);
	}
	
	public void gameSound()
	{
		MakeSound(_gameSound);
	}

	public void holeInSound()
	{
		MakeSound(_holeInSound);
	}
	
	public void mainInUrmaVaRog()
	{
		MakeSound(_mainInUrmaVaRog);
	}

	public void shiniNuOTransmis()
	{
		MakeSound(_shiniNuOTransmis);
	}
	
	public void dvijokMashina()
	{
		MakeSound(_dvijokMashina);
	}
	

	
	/// <summary>
	/// Play a given sound
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
