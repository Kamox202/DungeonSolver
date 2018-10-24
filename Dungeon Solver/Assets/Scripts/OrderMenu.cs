using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderMenu : MonoBehaviour {
     public static bool Running = false;
     public GameObject orderMenu, scena, reszta;
    

    // Use this for initialization
    void Start()
      {

      }

      // Update is called once per frame
      void Update () {
          if (Input.GetKeyDown(KeyCode.O))
          {
              if (Running) {
                  Resume();
              }
              else {
                  Pause();
              }
          }
      }

      [SerializeField]

      private void Resume() {
        orderMenu.SetActive(false);
        scena.SetActive(true);
        reszta.SetActive(true);
        Time.timeScale = 1f;
          Running = false;
      }

      private void Pause() {
        orderMenu.SetActive(true);
        scena.SetActive(false);
        reszta.SetActive(false);
        Time.timeScale = 0f;
          Running = true;
      }
}
