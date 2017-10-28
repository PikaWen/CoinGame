using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityChan2D.PCCU{

	[AddComponentMenu("Unity Chan 2D/Player HP")]
	public class PlayerHP : MonoBehaviour {

		[SerializeField]
		private float max;

		[SerializeField]
		private PassFloat normalized;
		[SerializeField]
		private UnityEvent dead;

		private float current;

		void Awake(){

			this.current = this.max;
		}

		public void Damaged(float value){

			if(!enabled) return;

			this.current = Mathf.Clamp(this.current - value , 0 , this.max);

			this.normalized.Invoke(this.current / this.max);

			if(this.current == 0){
			
				this.dead.Invoke();
				this.enabled = false;
			}
		}
		public void Update(){
			
			if (this.current <= this.max * 0.3) {
				
				Image img =  GameObject.Find("HP Value").GetComponent<Image>();
				img.color = UnityEngine.Color.red;
			}
		}
	}
}