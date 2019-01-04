using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

public static ScoreManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
        private int lives;                      
        private int score = 0;                                 

        //Awake is always called before any Start functions
        void Awake()
        {
            //Check if instance already exists
            if (instance == null)
                
                //if not, set instance to this
                instance = this;
            
            //If instance already exists and it's not this:
            else if (instance != this)
                
                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);    
            
            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);       
        }
   
        //Update is called every frame.
        void Update()
        {
            
        }

		public int GetScore()
		{
			return score;
		}
		public void SetScore(int value)
		{
			score = value;
		}
		
}
