var ifoto=3;

function slider(){
	if(ifoto==7){
		ifoto=1;
	}
	//document.getElementById("imgSlider").style.background="URL(f"+ifoto+".jpg)";
	document.getElementById("imgSlider").scr="'"+ifoto+".jpg'";
	ifoto++;
}

function iniciar(){
	var tmpSlider=setInterval(slider,3000);
}
