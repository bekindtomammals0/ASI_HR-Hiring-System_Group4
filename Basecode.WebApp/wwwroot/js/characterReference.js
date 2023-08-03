// Function to show the modal
function showModal() {
    var modal = document.getElementById("modal-screen");
    modal.style.display = "block";
}

// Function to close the modal
function closeModal() {
    var modal = document.getElementById("modal-screen");
    modal.style.display = "none";
}

// Add event listener to the "Submit" button
var submitBtn = document.getElementById("submit-btn");
submitBtn.addEventListener("click", showModal);

// Add event listener to the "Close" button in the modal
var closeBtn = document.getElementById("close-btn");
var cancelBtn = document.getElementById("cancel-btn");
closeBtn.addEventListener("click", closeModal);
cancelBtn.addEventListener("click", closeModal);
