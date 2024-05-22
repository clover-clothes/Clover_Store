const slider = document.getElementById("mySlider");
const output = document.getElementById("sliderValue");
output.textContent = slider.value;

slider.oninput = function() {
  output.textContent = this.value;
}
