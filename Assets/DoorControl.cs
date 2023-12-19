using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Content.Interaction
{
    

    public class DoorControl : MonoBehaviour
    {
        public string localId;
        public GameObject door;
        // Start is called before the first frame update
        void Start()
        {
            this.gameObject.GetComponent<Door>().m_Locked = true;
            DoorTask.current.onTaskComplete += OnComplete;

        }

        void Update()
        {
            /*
            if(this.gameObject.GetComponent<Door>().m_Locked = false)
            {
                float y = Mathf.Lerp(this.transform.rotation.y, 90f, 2f);
                door.transform.rotation.SetEulerRotation(0f, y, 0f);
            }
            */
        }

        private void OnComplete(string id)
        {
            Debug.Log(this.gameObject + " Detecting event for " + id);
            if (id == localId)
            {
                this.gameObject.GetComponent<Door>().onUnlock.Invoke();
                this.gameObject.GetComponent<Door>().m_Locked = false;
                Debug.Log("Unlocking");
            }
        }
    }
}
