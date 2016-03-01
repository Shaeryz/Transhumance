// http://formation-facile.fr

public var vitesseMouvement:float;
private var targetPosition:Vector3;
public var changeMoveType:boolean = false;

function Start(){
	targetPosition = gameObject.transform.position;
}

function Update(){
	if(Input.GetKeyDown(KeyCode.Mouse0)){
		var playerPlane=new Plane(Vector3.up, transform.position);
		var ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		var hitdist = 0.0;
		if (playerPlane.Raycast (ray, hitdist)){            
			var targetPoint = ray.GetPoint(hitdist);
			targetPosition=ray.GetPoint(hitdist);
			var targetRotation=Quaternion.LookRotation(targetPoint-transform.position);
			transform.rotation=targetRotation;
		}
	}
	if(!changeMoveType){
		transform.position=Vector3.Lerp(transform.position,targetPosition,Time.deltaTime*vitesseMouvement);
		print("Lerp");
	}
	else{
		transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime*vitesseMouvement*10);
		print("MoveTowards");
	}
}