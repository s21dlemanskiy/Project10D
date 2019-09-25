using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalPiecesList : MonoBehaviour {
	public GameObject[] metalPieces;
	public static MetalPiecesList instance = null; // Экземпляр объекта

	// Метод, выполняемый при старте игры
	void Awake ()
	{
		// Теперь, проверяем существование экземпляра
		if (instance == null) { // Экземпляр менеджера был найден
			instance = this; // Задаем ссылку на экземпляр объекта
		} else if (instance == this) { // Экземпляр объекта уже существует на сцене
			Destroy (gameObject); // Удаляем объект
		}
		metalPieces = GameObject.FindGameObjectsWithTag("Metal");
		Debug.Log (metalPieces);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
