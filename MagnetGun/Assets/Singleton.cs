using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton: MonoBehaviour {
	public static Singleton instance = null; // Экземпляр объекта

    // Метод, выполняемый при старте игры
    void Start ()
	{
		// Теперь, проверяем существование экземпляра
		if (instance == null) { // Экземпляр менеджера был найден
			instance = this; // Задаем ссылку на экземпляр объекта
		} else if (instance == this) { // Экземпляр объекта уже существует на сцене
			Destroy (gameObject); // Удаляем объект
		}
	}
}
