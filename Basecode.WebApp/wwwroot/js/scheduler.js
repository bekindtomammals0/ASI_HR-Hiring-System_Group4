var modal = document.getElementById("modal-screen");
var btns = document.querySelectorAll(".view-btn");
var span = document.getElementsByClassName("close")[0];

// Iterate over each button and attach the click event listener
btns.forEach(function (btn) {
    btn.addEventListener("click", function () {
        modal.style.display = "block";
    });
});

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
};

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target === modal) {
        modal.style.display = "none";
    }
};