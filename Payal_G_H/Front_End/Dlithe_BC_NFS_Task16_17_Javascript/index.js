
/*CSS */
function myFunction(x) {
    x.style.background = "yellow";
  }
  function mymessage() {
    alert("This message was triggered from the onload event");
  }
  function lighton() {
    document.getElementById('myimage').src = "bulbon.gif";
  }
  function lightoff() {
    document.getElementById('myimage').src = "bulboff.gif";
  }
/** */
  function mDown(obj) {
    obj.style.backgroundColor = "#1ec5e5";
    obj.innerHTML = "Release Me";
  }
  
  function mUp(obj) {
    obj.style.backgroundColor="#D94A38";
    obj.innerHTML="Thank You";
  }
/** */
  function mOver(obj) {
    obj.innerHTML = "Thank You"
  }
  
  function mOut(obj) {
    obj.innerHTML = "Mouse Over Me"
  }
  /** */
  function upperCase() {
    const x = document.getElementById("fname");
    x.value = x.value.toUpperCase();
  }
  
      