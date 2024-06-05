document.addEventListener("DOMContentLoaded", () => {
  document.querySelectorAll(".favorite-icon").forEach(icon => {
    icon.addEventListener("click", function(event){
      event.preventDefault();
      this.classList.toggle("active");
      const iconSpan = this.querySelector(".material-symbols-outlined");
      if (this.classList.contains("active")) {
        iconSpan.textContent = "favorite";
      } else {
        iconSpan.textContent = "favorite_border";
      }
      
    });
  });
});
